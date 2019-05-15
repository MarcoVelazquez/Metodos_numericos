import math as mth

fx = "e**-x-x"
dfx = "-e**-x-1"

def Newthon_Raphson_iteracion(iteracion,fx,dfx,fxi,dfxi,iteracion_stop,xi,xi_plus1,error):

    iteracion += 1
    e = mth.e


    if iteracion != iteracion_stop:

        if iteracion == 1:
            xi = float(input("Ingrese el valor de xi ---> "))
        else:
            xi = float(xi-((fxi)/(dfxi)))
        x = xi
        fxi = float(eval(fx))
        dfxi = float(eval(dfx))
        xi_plus1 = float(xi-((fxi)/(dfxi)))
        if iteracion == 1:
            error = "---"
        else:
            error = float((xi_plus1-xi)/xi_plus1)

        print(iteracion,"\t",xi,"\t",fxi,"\t",dfxi,"\t",xi_plus1,"\t",error)
        Newthon_Raphson_iteracion(iteracion,fx,dfx,fxi,dfxi,iteracion_stop,xi,xi_plus1,error)

    elif iteracion == iteracion_stop:
        if iteracion == 1:
            xi = float(input("\nIngrese el valor de xi ---> "))
            
        else:
            xi = float(xi-((fxi)/(dfxi)))
        x = xi
        fxi = float(eval(fx))
        dfxi = float(eval(dfx))
        xi_plus1 = float(xi-((fxi)/(dfxi)))
        if iteracion == 1:
            error = "---"
        else:
            error = float((xi_plus1-xi)/xi_plus1)

        print(iteracion,"\t",xi,"\t",fxi,"\t",dfxi,"\t",xi_plus1,"\t",error)
        return 0
    
def Menu():

    print("Función a utilizar: ", fx,"\nDerivada de la función: ",dfx,"\n")


    iteracion_stop = int(input("Ingresa la iteracion de parada ---> "))

    Newthon_Raphson_iteracion(0,fx,dfx,0,0,iteracion_stop,0,0,0)

Menu()