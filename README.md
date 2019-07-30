Se agregaron 3 metodos al desarrollo de arbol binario:

1. CreateTree es un metodo POST con la ruta de consumo "*/api/Arbol/CreateTree" donde se le envia como body  
   un array de numeros enteros en cualquier orden y devolvera el arbol formado de la siguiente manera:

se le envio en el body el array [2, 1, 3] y el metodo devuelve algo como lo siguiente:

{
    "Value": 2,
    "Nivel": 0,
    "Padre": null,
    "HijoDerecho": {
        "Value": 3,
        "Nivel": 1,
        "Padre": null,
        "HijoDerecho": null,
        "HijoIzquierdo": null
    },
    "HijoIzquierdo": {
        "Value": 1,
        "Nivel": 1,
        "Padre": null,
        "HijoDerecho": null,
        "HijoIzquierdo": null
    }
}


2. AddNodeTree es un metodo put con la ruta de consumo "*/api/Arbol/AddNodeTree"para adicionar un nuevo nodo a un arbol, se envia el arbol en el body en formato 
JSON y el nuevo numero entero que se agregara como nuevo nodo al arbol algo como la siguiente manera:

esto seria el arbol formado que se enviaria en el body:
{
    "Value": 2,
    "Nivel": 0,
    "Padre": null,
    "HijoDerecho": {
        "Value": 3,
        "Nivel": 1,
        "Padre": null,
        "HijoDerecho": null,
        "HijoIzquierdo": null
    },
    "HijoIzquierdo": {
        "Value": 1,
        "Nivel": 1,
        "Padre": null,
        "HijoDerecho": null,
        "HijoIzquierdo": null
    }
}

y el parametro value que le enviaremos el 4 para ser agregado al arbol y debe devolver algo como:

{
    "Value": 2,
    "Nivel": 0,
    "Padre": null,
    "HijoDerecho": {
        "Value": 3,
        "Nivel": 1,
        "Padre": null,
        "HijoDerecho": {
            "Value": 4,
            "Nivel": 2,
            "Padre": null,
            "HijoDerecho": null,
            "HijoIzquierdo": null
        },
        "HijoIzquierdo": null
    },
    "HijoIzquierdo": {
        "Value": 1,
        "Nivel": 1,
        "Padre": null,
        "HijoDerecho": null,
        "HijoIzquierdo": null
    }
}

donde se adiciono un nuevo hijo derecho al nodo 3


3.LowestCommonAncestor es un  metodo Get con la ruta de consumo "/api/Arbol/LowestCommonAncestor" trae el ancestro comun mas bajo y se le envia el arbol en el
  que se va a realizar la busqueda y los dos valores entre los cuales debe buscar el nodo comun mas bajo si no se llega a encontra alguno o ninguno de los nodos
  que se le envio como paramatro se devolvera -1 y se debe enviar la informacion de la siguiente manera:

en el body el arbol con el que se va a realizar la busqueda:

{
    "Value": 67,
    "Nivel": 0,
    "Padre": null,
    "HijoDerecho": {
        "Value": 76,
        "Nivel": 1,
        "Padre": null,
        "HijoDerecho": {
            "Value": 85,
            "Nivel": 2,
            "Padre": null,
            "HijoDerecho": {
                "Value": 87,
                "Nivel": 3,
                "Padre": null,
                "HijoDerecho": null,
                "HijoIzquierdo": null
            },
            "HijoIzquierdo": {
                "Value": 83,
                "Nivel": 3,
                "Padre": null,
                "HijoDerecho": null,
                "HijoIzquierdo": null
            }
        },
        "HijoIzquierdo": {
            "Value": 74,
            "Nivel": 2,
            "Padre": null,
            "HijoDerecho": null,
            "HijoIzquierdo": null
        }
    },
    "HijoIzquierdo": {
        "Value": 39,
        "Nivel": 1,
        "Padre": null,
        "HijoDerecho": {
            "Value": 44,
            "Nivel": 2,
            "Padre": null,
            "HijoDerecho": null,
            "HijoIzquierdo": null
        },
        "HijoIzquierdo": {
            "Value": 28,
            "Nivel": 2,
            "Padre": null,
            "HijoDerecho": {
                "Value": 29,
                "Nivel": 3,
                "Padre": null,
                "HijoDerecho": null,
                "HijoIzquierdo": null
            },
            "HijoIzquierdo": null
        }
    }
}

y los parametros value1 y value2 que seran los nodos entre los cuales debe buscar el nodo comun que pueden ser value1 =  29 y value2 = 44 al realizar la busqueda
retornara 39 que seria el nodo comun mas bajo del arbol entre esos dos nodos.

para las pruebas de consumo se uso el aplicativo postman. 
