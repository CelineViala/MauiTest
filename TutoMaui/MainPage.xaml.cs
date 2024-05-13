using System.Collections.ObjectModel;

namespace TutoMaui
{
    public class Contact
    {
        public string Name { get; set; }
  
        public string Phone { get; set; }

    }
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Contact> contacts =new ObservableCollection<Contact>();

        ObservableCollection<Contact> Contacts {  get; set; }


        public MainPage()
        {
            InitializeComponent();
            contacts.Add(new Contact() { Name = "Antho", Phone = "0102030405" });
            contacts.Add(new Contact() { Name = "Chloé", Phone = "0102030405" });
            contacts.Add(new Contact() { Name = "Kévin", Phone = "0102030405" });
            contacts.Add(new Contact() { Name = "Léa", Phone = "0102030405" });
            contacts.Add(new Contact() { Name = "Tom", Phone = "0102030405" });
            contacts.Add(new Contact() { Name = "Toto", Phone = "0102030405" });
            contacts.Add(new Contact() { Name = "Téo", Phone = "0102030405" });
            contacts.Add(new Contact() { Name = "Isa", Phone = "0102030405" });
            collectionView.ItemsSource = contacts;
        }

        
    }

}
