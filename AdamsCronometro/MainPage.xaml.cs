using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using AdamsCronometro.Resources;
using System.Windows.Threading;
using AdamsCronometro.Dados;

namespace AdamsCronometro
{
    public partial class MainPage : PhoneApplicationPage
    {
        private DispatcherTimer timer = new DispatcherTimer();
        private int tempo = 0;
        private List<Cronometro> tempos = new List<Cronometro>();

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            /* Construcao do Timer */
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += timer_Tick;

            /* Banco de dados */
            DataContext = App.bancoDeDados;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            /* Tempo @todo mudar */
            tempo += 1;
            atualizaLabel();

            /* Atualiza o ponteiro do cronometro */
            PointerAngle.Angle += 6;
        }

        private void atualizaLabel() {
            int minutos = tempo / 60;
            int segundos = tempo % 60;

            lblTempo.Text = minutos.ToString("00") + ":" + segundos.ToString("00");
        }

        // Metodo para iniciar o cronometro e registrar os tempos 
        private void Cronometro_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (timer.IsEnabled)
            {
                timer.Stop();
                salvarTempo();
            }
            else 
            {
                timer.Start();
            }
        }

        private void salvarTempo()
        {
            int minutos = tempo / 60;
            int segundos = tempo % 60;

            Cronometro cro = new Cronometro() { Tempo = (minutos.ToString("00") + ":" + segundos.ToString("00")) };
            tempos.Add(cro);
        }

        // Metodo para para o cronometro.
        private void Cronometro_DoubleTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            timer.Stop();

            tempo = 0;
            atualizaLabel();
            
            PointerAngle.Angle = 0;


            foreach (Cronometro cro in tempos)
            {
                App.bancoDeDados.AdicionarTempo(cro);
            }
            tempos = new List<Cronometro>();
        }
    }
}