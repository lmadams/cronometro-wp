using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace AdamsCronometro.Dados
{
    public class ConnectionToDatabase : DataContext
    {
        public Table<Cronometro> dados;

        public static string DBConnectionString = "Data Source=isostore:/Database.sdf";

        public ConnectionToDatabase(string connectionString)
            : base(connectionString)
        {

        }
    }

    public class MainData : INotifyPropertyChanged
    {
        private ConnectionToDatabase connection;
        private ObservableCollection<Cronometro> ListaCronometro;

        public MainData()
        {
            connection = new ConnectionToDatabase(ConnectionToDatabase.DBConnectionString);
            if (connection.DatabaseExists() == false)
            {
                connection.CreateDatabase();
            }

            QueryDados();
        }

        private void QueryDados()
        {
            var resultado = from Cronometro item in connection.dados
                            orderby item.ID ascending
                            select item;

            listaCronometro = new ObservableCollection<Cronometro>(resultado);
        }

        public ObservableCollection<Cronometro> listaCronometro
        {
            get
            {
                return ListaCronometro;
            }
            set
            {
                if (ListaCronometro != value)
                {
                    ListaCronometro = value;
                    NotifyPropertyChanged("listaCronometro");
                }
            }
        }

        public void AdicionarTempo(Cronometro novoCronometro)
        {
            connection.dados.InsertOnSubmit(novoCronometro);
            connection.SubmitChanges();

            QueryDados();
        }


        #region NotifyPropertyChanged
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
