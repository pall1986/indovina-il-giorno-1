using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace indovina_il_giorno
{
    public partial class Form2 : Form
    {
        StreamWriter writer;

        int MAX_TURN = 5;
        public int PUNTI_PER_PARTITA_INIZIALI;
        Random giorno_casuale = new Random();
        int giorno;
        enum Giorni_della_settimana
        {
            lunedi,
            martedi,
            mercoledi,
            giovedi,
            venerdi,
            sabato,
            domenica
        }
        Giorni_della_settimana giorno_scelto;
        Giorni_della_settimana giorno_test;
        private User[] users_in_form2;
        public int index;
        public int last_user;
        public bool save_file = false;
        public Form2(User[] users_in_form2, int i, int ultimo_utente)
        {
            InitializeComponent();
            /* passo l'array di utenti e l'indice dell'utente corrente*/
            index = i ;
            this.users_in_form2 = users_in_form2;
            PUNTI_PER_PARTITA_INIZIALI = this.users_in_form2[index].score;// prendo il punteggio dell'utente corrente
            last_user = ultimo_utente;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {/* Controllo se l'utente ha ancora turni disponibili
             * Se si genero un numero casuale tra 1 e 7 che rappresenta il giorno della settimana
             * Confronto il giorno scelto con quello inserito dall'utente
             * Se sono uguali l'utente vince e guadagna i punti rimanenti
             * Se sono diversi l'utente perde un turno e perde 10 punti
             * */
            if (MAX_TURN == 5)
            {

                giorno = (int)giorno_casuale.Next(0, 6);
                giorno_scelto = (Giorni_della_settimana)giorno;

            }
            if (giorno_scelto.ToString() == textBox1.Text.ToString())
            {
                MessageBox.Show("Complimenti Hai Individuato il giorno");
                save_file = true;
            }
            else
            {
                MessageBox.Show("errato");
                if (MAX_TURN > 0)
                {
                    MAX_TURN--;
                    PUNTI_PER_PARTITA_INIZIALI = PUNTI_PER_PARTITA_INIZIALI - 10;
                }

            }
            if (MAX_TURN == 0)
            {
                MessageBox.Show("Hai Perso, il giorno era " + giorno_scelto.ToString());
                save_file = true;

            }
            if (save_file == true)
            { // se l'utente ha vinto o ha finito i turni salvo il punteggio
                this.users_in_form2[index].score = PUNTI_PER_PARTITA_INIZIALI;
                /* Aggiorno il punteggio dell'utente corrente nell'array di struct User */
                ordina_classifica_bubble_sort();// ordino la classifica
                writer = new StreamWriter("classifica.txt");// apro il file in scrittura
                for (int i = 0; i < last_user ; i++)// ciclo per scrivere tutti gli utenti e i loro punteggi
                {
                    String riga = this.users_in_form2[i].username + "," + this.users_in_form2[i].score;
                    writer.WriteLine(riga);
                }
                writer.Close();// chiudo il file
                save_file = false;
                //visualzza la classifica sulla listbox
                for (int i = 0; i < last_user; i++)// ciclo per scrivere tutti gli utenti e i loro punteggi
                {
                    String riga = this.users_in_form2[i].username + "," + this.users_in_form2[i].score;
                    listBox1.Items.Add(riga);
                }

            }
        }
        public void ordina_classifica_bubble_sort()
        { 
              for (int i = 0; i < last_user - 1; i++)
              {
                  for (int j = 0; j < last_user - i - 1; j++)
                  {
                      if (users_in_form2[j].score < users_in_form2[j + 1].score)
                      {
                          // Scambia gli elementi
                          User temp = users_in_form2[j];
                          users_in_form2[j] = users_in_form2[j + 1];
                          users_in_form2[j + 1] = temp;
                      }
                  }
            }
        }

    }
}
