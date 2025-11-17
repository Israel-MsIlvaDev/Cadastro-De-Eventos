
using EventosMaui.Models;

namespace EventosMaui.Views
{
    public partial class CadastroPage : ContentPage
    {

        private Evento eventoAtual;

        public CadastroPage()
        {
            InitializeComponent();

            eventoAtual = new Evento();

            this.BindingContext = eventoAtual;
        }

        private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            try
            {
                if (eventoAtual.DataTermino < eventoAtual.DataInicio)
                {
                    await DisplayAlert("Data Inválida", "A data de término não pode ser anterior à data de início.", "OK");
                    return;
                }

                await Navigation.PushAsync(new ResumoPage
                {
                    BindingContext = eventoAtual
                });
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }
        }
    }
}