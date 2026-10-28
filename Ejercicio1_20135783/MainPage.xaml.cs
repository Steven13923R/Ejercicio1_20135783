namespace Ejercicio1_20135783
{
    public partial class MainPage : ContentPage
    {
        
            public MainPage()
            {
                InitializeComponent();
            }

            private void OnInvertirClicked(object sender, EventArgs e)
            {
                // Intentar convertir los valores ingresados a enteros
                bool isAValid = int.TryParse(EntryA.Text, out int a);
                bool isBValid = int.TryParse(EntryB.Text, out int b);
                bool isCValid = int.TryParse(EntryC.Text, out int c);
                bool isDValid = int.TryParse(EntryD.Text, out int d);

                // Validar que todos los campos contengan números enteros válidos
                if (isAValid && isBValid && isCValid && isDValid)
                {
                    // El orden inverso de A, B, C, D es: D, C, B, A
                    ResultadoLabel.TextColor = Colors.Green;
                    ResultadoLabel.Text = $"Resultado inverso:\n{d}, {c}, {b}, {a}";
                }
                else
                {
                    ResultadoLabel.TextColor = Colors.Red;
                    ResultadoLabel.Text = "Por favor, ingrese números enteros válidos en todos los campos.";
                }
            
        }
    }
}
