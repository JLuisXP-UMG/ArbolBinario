using ArbolBinario;

ArbolBinario2 arbolBinario = new ArbolBinario2();

arbolBinario.PoblarArbol(arbolBinario.NodoRaiz);

arbolBinario.RecorridoPreorden(arbolBinario.NodoRaiz);

Console.ReadKey();