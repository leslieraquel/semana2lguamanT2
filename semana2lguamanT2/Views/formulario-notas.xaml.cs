namespace semana2lguamanT2.Views;

public partial class formulario_notas : ContentPage
{
	public formulario_notas()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            string nombre = pkCompaneros.ToString();

            if (pkCompaneros.SelectedItem == null)
            {
                await DisplayAlert("Error", "Seleccione un compañero", "OK");
                return;
            }

            string companero = pkCompaneros.SelectedItem.ToString();
            double seg1 = Convert.ToDouble(txtSeguimiento1.Text);
            double ex1 = Convert.ToDouble(txtExamen1.Text);
            double seg2 = Convert.ToDouble(txtSeguimiento2.Text);
            double ex2 = Convert.ToDouble(txtExamen2.Text);

            // Validación de rango
            if (seg1 < 0 || seg1 > 10 ||
                ex1 < 0 || ex1 > 10 ||
                seg2 < 0 || seg2 > 10 ||
                ex2 < 0 || ex2 > 10)
            {
                await DisplayAlert("Error",
                    "Las notas deben estar entre 0 y 10",
                    "OK");
                return;
            }

            // Cálculos
            double parcial1 = (seg1 * 0.3) + (ex1 * 0.2);
            double parcial2 = (seg2 * 0.3) + (ex2 * 0.2);
            double final = parcial1 + parcial2;

            string estado = "";

            if (final >= 7)
                estado = "APROBADO";
            else if (final >= 5 && final <= 6.9)
                estado = "COMPLEMENTARIO";
            else
                estado = "REPROBADO";

            await DisplayAlert("Resultado",
                "estudiante: " + companero + "\n" +
                "Fecha: " + dpFecha.Date.ToShortDateString() + "\n" +
                "Nota Parcial 1: " + parcial1.ToString("0.00") + "\n" +
                "Nota Parcial 2: " + parcial2.ToString("0.00") + "\n" +
                "Nota Final: " + final.ToString("0.00") + "\n" +
                "Estado: " + estado,
                "OK");
        }
        catch
        {
            await DisplayAlert("Error",
                "Ingrese valores numéricos válidos",
                "OK");
        }
    }
}