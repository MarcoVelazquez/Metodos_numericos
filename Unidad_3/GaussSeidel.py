#Funciones para el método de Gauss - Seidel

def ComprobarMatriz(matriz,constantes):
    
    bandera = True
    
    for i in range(3):

        for j in range(3):

            if bandera == True:

                if matriz[i][i] >= matriz[i][j]:
                    bandera = True
                else:
                    return False

            else: 

                return False

    return True

            



def Iterar(matriz,constantes,x1,x2,x3):

    x1 = (constantes[0] + matriz[0][1]*x2 + matriz[0][2]*x3)/matriz[0][0]   
    x2 = (constantes[1] + matriz[1][0]*x1 + matriz[1][2]*x3)/matriz[1][1]
    x3 = (constantes[2] + matriz[2][0]*x1 + matriz[2][1]*x2)/matriz[2][2]

    return x1, x2, x3

    