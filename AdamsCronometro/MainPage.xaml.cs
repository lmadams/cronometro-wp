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

namespace AdamsCronometro
{
    public partial class MainPage : PhoneApplicationPage
    {
        private DispatcherTimer timer = new DispatcherTimer();
        private int tempo = 0;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            /* Construcao do Timer */
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += timer_Tick;
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
            }
            else 
            {
                timer.Start();
            }
        }

        // Metodo para para o cronometro.
        private void Cronometro_DoubleTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            timer.Stop();

            tempo = 0;
            atualizaLabel();
            
            PointerAngle.Angle = 0;
            // Pivot.SelectedIndex = 1;
        }
    }
}