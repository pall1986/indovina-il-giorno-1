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
        User[] utenti = new User[1000];
        public bool new_struct = false;

        public Form1()
        {
            InitializeComponent();
            /* Controllo se il file esiste, se non esiste lo creo
             * Se esiste leggo gli utenti e i loro punteggi e li salvo in un array di struct User
             * */
            if (!File.Exists("classifica.txt"))
            {
                new_struct = true;
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
            if (textBoxUser.Text == "")// controllo se lo username � vuoto
            {
                MessageBox.Show("Inserire uno username valido");
            }
            else
            {
                int i;
                bool trovato = false;
                if (new_struct == false)
                {

                    for (i = 0; i < index; i++)// controllo se l'utente esiste
                    {
                        if (utenti[i].username == textBoxUser.Text)
                        {
                            utenti[i].score = utenti[i].score + 100;
                            //utenti[i].username = textBoxUser.Text;
                            trovato = true;
                        }
                    }
                    if (trovato == false)// nuovo utente
                    {
                        //i = index-1 ;

                        utenti[i].username = textBoxUser.Text;
                        utenti[i].score = 100;
                        index++;
                        // Aggiungi l'utente alla lista 
                    }
                }
                else
                {
                    i = 0;
                    index = +1;

                    utenti[i].username = textBoxUser.Text;
                    utenti[i].score = 100;
                    new_struct = true;

                }

                this.Hide();
                Form2 form2 = new Form2(utenti, i, index);// passo l'array di utenti e l'indice dell'utente corrente
                form2.Show();
            }
        }
    }
}
