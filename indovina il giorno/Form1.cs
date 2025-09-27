using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using System.Windows.Forms;
using System;
namespace indovina_il_giorno
{
    public partial class Form1 : Form
    {
        StreamReader reader;
        StreamWriter writer;
        public int index = 0;
        User[] utenti = new User[1000];
        
        public Form1()
        {
            InitializeComponent();
            /* Controllo se il file esiste, se non esiste lo creo
             * Se esiste leggo gli utenti e i loro punteggi e li salvo in un array di struct User
             * */
            if (!File.Exists("classifica.txt"))
            {
                File.Create("classifica.txt").Close();
            }
            else
            {
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
                for (i = 0; i <= index; i++)// controllo se l'utente esiste
                {
                    if (utenti[i].username == textBoxUser.Text)
                    {
                        utenti[i].score = utenti[i].score+100;
                        utenti[i].username = textBoxUser.Text;
                    }
                }
                if ( i == index)// nuovo utente
                {
                   i= index+1;
                    utenti[i].username = textBoxUser.Text;
                    utenti[i].score = 100;
                    // Aggiungi l'utente alla lista 
                }

                this.Hide();
                Form2 form2 = new Form2(utenti,i );// passo l'array di utenti e l'indice dell'utente corrente
                form2.Show();
            } }
    }
}
