

namespace semana2lguamanT2.Views;

public partial class login : ContentPage
{
	public login()
	{
		InitializeComponent();
    }

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string[] usuario = { "Carlos", "Ana", "Jose" };
        string[]  pass = { "carlos123", "ana123", "jose123" };


        bool acceso = false;

        for (int i = 0; i < usuario.Length; i++)
        {
            if (txtUsuario.Text == usuario[i] && txtContrasenia.Text == pass[i])
            {
                acceso = true;
                Navigation.PushAsync(new Views.formulario_notas());

                DisplayAlert("Info", "Bienvenido"+ usuario[i], "OK");

                break;
            }
        }

        if (!acceso)
        {
            DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }

    }
}