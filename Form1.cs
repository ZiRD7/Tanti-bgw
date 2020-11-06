using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanti_bgw
{
    public partial class frmMain : Form
    {
        // variabili di tipo backGroundWorker
        BackgroundWorker bgw1, bgw2;

        public frmMain()
        {
            InitializeComponent();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {

        }


        private void btnAvvio_Click(object sender, EventArgs e)
        {
            // Creo 2 backGroundWorker e li avvio

            bgw1 = new BackgroundWorker();
            bgw1.WorkerReportsProgress = true;
            bgw1.WorkerSupportsCancellation = true;
            bgw1.DoWork += Bgw_DoWork;
            bgw1.ProgressChanged += Bgw_ProgressChanged;
            bgw1.RunWorkerCompleted += Bgw_RunWorkerCompleted;

            bgw2 = new BackgroundWorker();
            bgw2.WorkerReportsProgress = true;
            bgw2.WorkerSupportsCancellation = true;
            bgw2.DoWork += Bgw_DoWork;
            bgw2.ProgressChanged += Bgw_ProgressChanged;
            bgw2.RunWorkerCompleted += Bgw_RunWorkerCompleted;

            bgw1.RunWorkerAsync(tb);
            bgw2.RunWorkerAsync(tb);
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            bgw1.CancelAsync();
            bgw2.CancelAsync();
        }


        BackgroundWorker[] v = new BackgroundWorker[100];
        private void btnAvvio100_Click(object sender, EventArgs e)
        {
            // riempo il vettore di backGroundWorker
            for (int i = 0; i < 100; i++)
            {
                BackgroundWorker bwg1 = new BackgroundWorker();
                bwg1.WorkerReportsProgress = true;
                bwg1.WorkerSupportsCancellation = true;
                bwg1.DoWork += Bgw_DoWork;
                bwg1.RunWorkerCompleted += Bgw_RunWorkerCompleted;
                bwg1.ProgressChanged += Bgw_ProgressChanged;
                v[i] = bwg1;
            }
            // faccio partire i  100 backGroundWorker
            foreach (var bwg in v)
            {
                bwg.RunWorkerAsync(tb100);
            }
        }


        private void btnStop100_Click(object sender, EventArgs e)
        {
            // blocco i vari lavori
            foreach (var bwg in v)
            {
                bwg.CancelAsync();
            }
        }



        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker; // salvo quale backGroundWorker "mi ha chiamata"
            TextBox tb = e.Argument as TextBox; // salvo la textBox passata come argomento della .RunWorkerAsync
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100); // piccola pausa
                bgw.ReportProgress(i, tb); 
                if(bgw.CancellationPending) // se è stata richiesta la cancellazione
                {
                    e.Result = (false, tb); // risultato se è stata richiesta la cancellazione
                    return; // termino il ciclo
                }
            }
            e.Result = (true, tb); // risultato se NON è stata richiesta la cancellazione
        }


        private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            TextBox tb = e.UserState as TextBox; // salvo la textBox passato nella .ReportProgess
            tb.Text = e.ProgressPercentage + Environment.NewLine + tb.Text; //tn.Text = e.ProgressPecentage + "\r\n" + tb.Text
        }

        private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var (completato, tb) = (ValueTuple<bool, TextBox>)e.Result; // tupla della e.Result
            // in base al valore di e.Result stampo se il lavoro è stato concluso o cancellato
            tb.Text = completato ? "Concluso" + Environment.NewLine + tb.Text :
                                   "Cancellato" + Environment.NewLine + tb.Text;
        }

    }
}
