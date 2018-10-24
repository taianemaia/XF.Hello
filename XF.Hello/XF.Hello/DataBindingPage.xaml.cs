using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Hello.App_Code;
using XF.Hello.NewFolder;

namespace XF.Hello
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DataBindingPage : ContentPage
	{
		public DataBindingPage ()
		{         
            InitializeComponent();

            Aluno aluno = InitializeAluno();
            Professor professor  = InitializeProfessor();
            painelAluno.BindingContext = aluno;
            painelProfessor.BindingContext = professor;
		}

        private Aluno InitializeAluno()
        {
            return new Aluno()
            {
                Id = Guid.NewGuid(),
                Nome = "João Silva",
                Email = "joao@fiap.com"
            };
        }

        private Professor InitializeProfessor()
        {
            return new Professor()
            {
                Nome = "Fabio Silva",
                Curso = "ADM"
            };
        }
    }
}