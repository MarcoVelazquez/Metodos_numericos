#Practica unidad 3: Matrices

import GaussSimple as Gs
import GaussSeidel as Gd

def CrearMatrizCuadrada(size):
    matriz = []
    for i in range(size):
        datos = []
        for j in range(size):
            datos.append(float(input("Ingrese el valor en la posición [" + str(i+1) + "," + str(j+1) + "] ")))
        matriz.append(datos)

    return matriz
   
def Constantes(size):
    constantes = []
    for i in range(size):
        constantes.append(float(input("Ingresa el valor de la constante " + str(i+1) + ": ")))

    return constantes

def GaussSimple():

    print("\n     --- Esto es Gauss - Simple ---\n")

    matriz = CrearMatrizCuadrada(3)

    constantes = Constantes(3) 
   
    matriz,constantes = Gs.PrimeraIteracion(matriz,constantes)
    
    matriz,constantes = Gs.SegundaIteracion(matriz,constantes)

    matriz,constantes = Gs.TerceraIteracion(matriz,constantes)

    constantes = Gs.XValue(matriz,constantes)

    print("\n---- Valor de las constantes ----\n\n" + str(constantes)+"\n")

    input("\n--- Presione enter para salir ---")

def GaussSeidel():

    print("\n     --- Esto es Gauss - Seidel ---\n")

    matriz = CrearMatrizCuadrada(3)

    constantes = Constantes(3)

    iteracionDeParada = int(input("\nIngrese la iteración de parada ---> "))

    if Gd.ComprobarMatriz(matriz,constantes) == True:

        print("Iteración    x1      x2      x3")

        x1,x2,x3 = 0,0,0

        for i in range(iteracionDeParada):

            x1,x2,x3 = Gd.Iterar(matriz,constantes,x1,x2,x3)

            print(str(i) + "     " + str(x1) + "     " + str(x2) + "     " + str(x3))

    else:

        print("Esta matriz no puede resolverse mediante Gauss - Seidel")
            
        

GaussSeidel() 

GaussSimple()
        





		
