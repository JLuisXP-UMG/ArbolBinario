using ArbolBinario;

//ArbolBinario2 arbolBinario = new ArbolBinario2();

//arbolBinario.PoblarArbol(arbolBinario.NodoRaiz);

//arbolBinario.RecorridoPreorden(arbolBinario.NodoRaiz);

ABB abb = new ABB();

abb.PoblarABB(abb.NodoRaiz, new NodoABB(120));
abb.PoblarABB(abb.NodoRaiz, new NodoABB(87));
abb.PoblarABB(abb.NodoRaiz, new NodoABB(43));
abb.PoblarABB(abb.NodoRaiz, new NodoABB(22));
abb.PoblarABB(abb.NodoRaiz, new NodoABB(65));
abb.PoblarABB(abb.NodoRaiz, new NodoABB(56));
abb.PoblarABB(abb.NodoRaiz, new NodoABB(99));
abb.PoblarABB(abb.NodoRaiz, new NodoABB(93));
abb.PoblarABB(abb.NodoRaiz, new NodoABB(140));
abb.PoblarABB(abb.NodoRaiz, new NodoABB(130));
abb.PoblarABB(abb.NodoRaiz, new NodoABB(135));

abb.RecorridoInorden(abb.NodoRaiz);

NodoABB nodoBuscado = abb.BuscarNodo(abb.NodoRaiz, 99);

Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"Nodo buscado: {(nodoBuscado != null ? nodoBuscado.Informacion : "No existe!!!")}");

Console.ReadKey();