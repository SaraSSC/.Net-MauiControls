using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiDataBindings.Models
{
    public class Produto : INotifyPropertyChanged
    {
        private string nome;
        private decimal preco;
        private int stock;
        public string Nome
        { 
            get => nome; 
            set
            {
                nome = value;
                OnPropertyChanged();
            }
        }
        public decimal Preco
        {
            get => preco;
            set
            {
                preco = value;
                OnPropertyChanged();
            }
        }
        public int Stock
        {
            get => stock;
            set
            {
                stock = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
