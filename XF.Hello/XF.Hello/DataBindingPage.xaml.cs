using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Hello.NewFolder;

namespace XF.Hello
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DataBindingPage : ContentPage
	{
		public DataBindingPage ()
		{
            Aluno aluno = new Aluno()
            {
                Id = Guid.NewGuid(),
                Nome = "João Silva",
                Email = "joao@fiap.com"
            };

            BindingContext = aluno;

			InitializeComponent ();
		}
	}
}