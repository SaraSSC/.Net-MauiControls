using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiControls.Models
{
    public class FotoViewModel
    {
        public ObservableCollection<Foto> fotos { get; private set; }

        public ObservableCollection<Foto> Fotos
        {
            get { return fotos; }
            set { fotos = value; }
        }

        public FotoViewModel()
        {
            Fotos = new ObservableCollection<Foto>()
            {
                new Foto() { Name = "Foto 1", ImageUrl = "https://picsum.photos/200" },
                new Foto() { Name = "Foto 2", ImageUrl = "https://picsum.photos/300" },
                new Foto() { Name = "Foto 3", ImageUrl = "https://picsum.photos/400" },
                new Foto() { Name = "Foto 4", ImageUrl = "https://picsum.photos/500" },
                new Foto() { Name = "Foto 5", ImageUrl = "https://picsum.photos/600" },
                new Foto() { Name = "Foto 1", ImageUrl = "https://picsum.photos/200" },
                new Foto() { Name = "Foto 2", ImageUrl = "https://picsum.photos/300" },
                new Foto() { Name = "Foto 3", ImageUrl = "https://picsum.photos/400" },
                new Foto() { Name = "Foto 4", ImageUrl = "https://picsum.photos/500" },
                new Foto() { Name = "Foto 5", ImageUrl = "https://picsum.photos/600" },
                new Foto() { Name = "Foto 1", ImageUrl = "https://picsum.photos/200" },
                new Foto() { Name = "Foto 2", ImageUrl = "https://picsum.photos/300" },
                new Foto() { Name = "Foto 3", ImageUrl = "https://picsum.photos/400" },
                new Foto() { Name = "Foto 4", ImageUrl = "https://picsum.photos/500" },
                new Foto() { Name = "Foto 5", ImageUrl = "https://picsum.photos/600" },
            };
        }
    }
}
