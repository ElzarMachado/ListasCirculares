using ListasCirculares;

Lista listas = new Lista();

Console.WriteLine("Mostrando elementos de la lista");
listas.AgregarNodo("Cero");
listas.AgregarNodo("Uno");
listas.AgregarNodo("Dos");
listas.AgregarNodo("Tres");
Console.WriteLine(listas.RecorrerLista());
Console.WriteLine("---------------------------------------------------------");

Console.WriteLine();
Console.WriteLine("Buscando Nodo Dos");
Nodo nodoBusqueda = listas.Buscar("Dos");
Console.WriteLine(nodoBusqueda.Valor);
Console.WriteLine("--------------------------------------------------------");

Console.WriteLine("Buscando nodo anterior al Dos");
Nodo nodoDos = listas.Buscar("Dos");
Console.WriteLine(nodoDos.Ant.Valor);
Console.WriteLine("--------------------------------------------------------");

Console.WriteLine("Borrando Dos");
listas.BorrarNodo("Dos");
Console.WriteLine(listas.RecorrerLista());