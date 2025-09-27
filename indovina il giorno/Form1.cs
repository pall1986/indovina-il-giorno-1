using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using System.Windows.Forms;
using System;
namespace indovina_il_giorno
{
    public partial class Form1 : Form
    {
        StreamReader reader;
        
        public int index = 0;
        public Boolean file_trovato ;
        User[] utenti = new User[1000];
        public Boolean found_user = false;

        public Form1()
        {
            InitializeComponent();
            /* Controllo se il file esiste, se non esiste lo creo
             * Se esiste leggo gli utenti e i loro punteggi e li salvo in un array di struct User
             * */
            if (!File.Exists("classifica.txt"))
            {
                file_trovato = false;
                File.Create("classifica.txt").Close();
                
            }
            else
            {
                file_trovato = true;
                reader = new StreamReader("classifica.txt");
                string line;
                
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    utenti[index].username = parts[0];
                    utenti[index].score = int.Parse(parts[1]);
                    // Aggiungi l'utente alla lista o visualizzalo
                    index++;
                }
                reader.Close();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertUser_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "")// controllo se lo username è vuoto
            {
                MessageBox.Show("Inserire uno username valido"); 
                    }
            else {

                int i;
                if (file_trovato == true)
                {

                    for (i = 0; i < index; i++)// controllo se l'utente esiste
                    {
                        if (utenti[i].username == textBoxUser.Text)
                        {
                            utenti[i].score = utenti[i].score + 100;
                            utenti[i].username = textBoxUser.Text;
                            found_user = true;
                        }
                    }
                    if (found_user == false)// nuovo utente
                    {

                        utenti[i].username = textBoxUser.Text;
                        utenti[i].score = 100;
                        
                        index++;
                        // Aggiungi l'utente alla lista 
                    }
                }
                else // primo utente
                {
                    i = 0;
                    utenti[i].username = textBoxUser.Text;
                    utenti[i].score = 100;
                    index++;
                    
                }
                this.Hide();
                Form2 form2 = new Form2(utenti,i, index );// passo l'array di utenti e l'indice dell'utente corrente
                form2.Show();
            } }
    }
}
