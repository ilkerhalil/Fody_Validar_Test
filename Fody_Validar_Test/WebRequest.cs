using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Fody_Validar_Test.Annotations;
using Validar;

namespace Fody_Validar_Test
{
    [InjectValidation]
    public class WebRequest: INotifyPropertyChanged
    {
        
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname is required")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [Phone(ErrorMessage = "Phone Number is not valid")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "IpAddress is required")]
        [RegularExpression(@"\b(?:[0-9]{1,3}\.){3}[0-9]{1,3}\b")]
        public string IpAddress { get; set; }

        [EmailAddress(ErrorMessage = "Email is not valid")]
        public string EMail { get; set; }


        public override string ToString()
        {
            return $"Name: {Name}, SurName: {SurName}, PhoneNumber: {PhoneNumber}, IpAddress: {IpAddress}, EMail: {EMail}";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}