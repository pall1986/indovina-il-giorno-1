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

namespace indovina_il_giorno
{
    public partial class Form2 : Form
    {
        
         
        int MAX_TURN = 5;
        int PUNTI_PER_PARTITA_INIZIALI ;
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
        public Form2(User[] users_in_form2, int i)
        {
            InitializeComponent();
            /* passo l'array di utenti e l'indice dell'utente corrente*/
            index = i;
            this.users_in_form2 = users_in_form2;
            PUNTI_PER_PARTITA_INIZIALI = this.users_in_form2[index].score;// prendo il punteggio dell'utente corrente
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

                giorno = (int)giorno_casuale.Next(1, 7);
                giorno_scelto = (Giorni_della_settimana)giorno;

            }
            if (giorno_scelto.ToString() == textBox1.Text.ToString())
            {
                MessageBox.Show("Complimenti Hai Individuato il giorno");
           
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
            this.users_in_form2[index].score = PUNTI_PER_PARTITA_INIZIALI;
        }
    }
}
