namespace semana2lguamanT2.Views;

public partial class bienvenida : ContentPage
{
    string nombreUsuario;
    public bienvenida(string usuario)
	{
		InitializeComponent();

        nombreUsuario = usuario;
        lblBienvenida.Text = "Bienvenido " + nombreUsuario;


    }
}