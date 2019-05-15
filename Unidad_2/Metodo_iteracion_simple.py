#Método iteración simple de punto fijo

import math as mth


def Error(xi,gxi,iteracion):

    if iteracion == 1:

        error = 0
    else:

        error = float(mth.fabs((gxi - xi)/gxi)*100)

    return error

def Gxi(xi,gx):
    e = mth.e
    x = xi

    gxi = eval(gx)

    return gxi

def Fxi(xi,fx):

    e = mth.e
    x = xi

    fxi = eval(fx)

    return fxi
def Iteracion_simple(xi,gx,fx,error_parada,iteracion):

    iteracion += 1

    if iteracion != 1:

        if Error(xi,Gxi(xi,gx),iteracion) > error_parada:

            print(iteracion,"\t\t",int(xi),"\t",int(Gxi(xi,gx)),"\t",int(Fxi(xi,fx)),"\t",int(Error(xi,Gxi(xi,gx),iteracion)))

            Iteracion_simple(Gxi(xi,gx),gx,fx,error_parada,iteracion)
        else:
            print("""
            La tolerancia ha sido satisfacida en g(x) igual a """,Gxi(xi,gx)," y un error de ",Error(xi,Gxi(xi,gx),iteracion),"%\n")
            return False

    else:

        if Error(xi,Gxi(xi,gx),iteracion) != error_parada:

            print(iteracion,"\t\t",int(xi),"\t",int(Gxi(xi,gx)),"\t",int(Fxi(xi,fx)),"\t",int(Error(xi,Gxi(xi,gx),iteracion)))

            Iteracion_simple(Gxi(xi,gx),gx,fx,error_parada,iteracion)
        else:
            print("""
            La tolerancia ha sido satisfacida en g(x) igual a """,Gxi(xi,gx)," y un error de ",Error(xi,Gxi(xi,gx),iteracion),"%\n")
            return False



def Menu():
    #Encabezado
    print("\n\t MÉTODOS NUMERICOS\n\n\tMétodo de punto fijo\n\n")

    fx = input("Ingresa f(x) ---> ")
    gx = input("\nIngresa g(x) ---> ")

    xi = float(input("\nIngresa el valor de xi ---> "))

    error_parada = float(input("Introduce el error de parada ---> "))

    print("Iteracion\txi\tg(xi)\tf(xi)\tError")

    Iteracion_simple(xi,gx,fx,error_parada,0)

Menu()
        


        
