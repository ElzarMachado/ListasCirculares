using ListasCirculares;

Lista listas = new Lista();

Console.WriteLine("Mostrando elementos de la lista");
listas.AgregarNodo("Cero");
listas.AgregarNodo("Uno");
listas.AgregarNodo("Dos");
listas.AgregarNodo("Tres");
listas.AgregarNodo("Cuatro");
Console.WriteLine(listas.RecorrerLista());
Console.WriteLine("---------------------------------------------------------");

Console.WriteLine("Buscando siguiente a Tres");
Nodo nodoBusqueda = listas.Buscar("Tres");
Console.WriteLine(nodoBusqueda.Enlace.Valor);
Console.WriteLine("--------------------------------------------------------");

Console.WriteLine("Borrar Cero");
listas.BorrarNodo("Cero");
Console.WriteLine(listas.RecorrerLista());