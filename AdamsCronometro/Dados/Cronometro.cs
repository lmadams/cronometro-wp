using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace AdamsCronometro.Dados
{
    [Table]
    class Cronometro : INotifyPropertyChanged
    {
        #region id
        private int id;

        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                if (value != id)
                {
                    id = value;
                    NotifyPropertyChanged("ID");
                }
            }
        }
        #endregion

        #region tempo
        private int tempo;

        [Column]
        public int Tempo
        {
            get
            {
                return tempo;
            }
            set
            {
                if (value != tempo)
                {
                    tempo = value;
                    NotifyPropertyChanged("Tempo");
                }
            }
        }
        #endregion


        #region NotifyProperty
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
