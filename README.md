# Calculadora en Xamarin Nativo Android

##Pasos en la vista activity_main

1.- Se requiere 2 EditText, 4 Button y 1 TextView
2.- Los 2 EditText son usuados para ingresar cantidades que se procesan (@+id/Cantidad1 y @+id/Cantidad2)
3.- Los 4 Button son usuados como las operaciones que puede realizar la calculadora, estos pueden aumentar (@+id/Sumar - @+id/Restar - @+id/Multiplicar - @+id/Dividir)
4.- El TextView presenta el resuldo de las operaciones (@+id/Resultado)

##Pasos en la lógica MainActivity

1.- Se inicializa los elementos agregados en la vista (Button sumar = FindViewById<Button>(Resource.Id.Sumar);)
2.- A cada boton/operación se le agrega un método CLick (sumar.Click += (sender, e) =>{};)
3.- Dentro de este se inicializan las entradas del usuario (EditText cantidad1 = FindViewById<EditText>(Resource.Id.Cantidad1);)
4.- Para poder trabajar en operaciones matemáticas, las entradas son transformadas a valores numéricos (int factor1 = int.Parse(cantidad1.Text);)
5.- Se procede a asignar la lógica de cada operación al resultado inicializado previamente (resultado.Text = (factor1 + factor2).ToString();)
6.- Ejecutar la aplicación.
