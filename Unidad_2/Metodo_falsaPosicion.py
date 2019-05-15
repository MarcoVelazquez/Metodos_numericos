#Método de bisección


import math as mth

#parser = Parser()

def Fxu(xu,ecuacion):
    e = mth.e   #}
    pi = mth.pi  #}Constantes
    x = xu      #}
    fxu = eval(ecuacion)
    return fxu

def Fxi(xi,ecuacion):
    e = mth.e   #}
    pi = mth.pi  #}Constantes
    x = xi      #}
    fxi = eval(ecuacion)
    return fxi

def Xr(xi,xu,ecuacion):
    xr = float(xu-((xi-xu))/(Fxi(xi,ecuacion)-Fxu(xu,ecuacion)))
    return xr

def Fxr(xr,ecuacion):
    e = mth.e
    pi = mth.pi
    x = xr
    fxr = eval(ecuacion)
    return fxr

def Error(xr,xr_anterior):
    error = float((mth.fabs((xr - xr_anterior)/(xr)))*100)
    return error

def Biseccion_error(xi,xu,ecuacion,xr_anterior,iteracion,error_sugerido):
    iteracion+=1
    fxi = Fxi(xi,ecuacion)
    xr = Xr(xi,xu,ecuacion)
    fxr = Fxr(xr,ecuacion)
    error = Error(xr,xr_anterior)

    print(iteracion,"\t\t",mth.floor(xi),"\t",mth.floor(xu),"\t",mth.floor(fxi),"\t",mth.floor(xr),"\t",mth.floor(fxr),"\t",mth.floor(error),"\n")
    
    if fxi*fxr < 0:
        xu = xr
    elif fxi*fxr > 0:
        xi = xr
    elif fxi*fxr == 0:
        print("""
        La tolerancia ha sido satisfacida en xr igual a """,xr," y un error de ",error,"%\n")
        return False

    if error > error_sugerido:
        Biseccion_error(xi,xu,ecuacion,xr,iteracion,error_sugerido)

    elif error < error_sugerido or error == error_sugerido:
        print("""
        La tolerancia ha sido satisfacida en xr igual a """,xr," y un error de ",error,"%\n")
        return False

def Biseccion_iteracion(xi,xu,ecuacion,xr_anterior,iteracion,iteracion_sugerida):
    iteracion += 1
    fxi = Fxi(xi,ecuacion)
    xr = Xr(xi,xu,ecuacion)
    fxr = Fxr(xr,ecuacion)
    error = Error(xr,xr_anterior)
    if iteracion != 1:
        print(iteracion,"\t\t",mth.floor(xi),"\t",mth.floor(xu),"\t",mth.floor(fxi),"\t",mth.floor(xr),"\t",mth.floor(fxr),"\t",mth.floor(error),"\n")
    else : 
        print(iteracion,"\t\t",mth.floor(xi),"\t",mth.floor(xu),"\t",mth.floor(fxi),"\t",mth.floor(xr),"\t",mth.floor(fxr),"\t0\n")
    if fxi*fxr < 0:
        xu = xr
    elif fxi*fxr > 0:
        xi = xr
    elif fxi*fxr == 0:
        print("""
        La tolerancia ha sido satisfacida en xr igual a """,xr," y un error de ",error,"%\n")
        return False

    if iteracion != iteracion_sugerida:
        Biseccion_iteracion(xi,xu,ecuacion,xr,iteracion,iteracion_sugerida)

    else:
        print("""
        La tolerancia ha sido satisfacida en xr igual a """,xr," y un error de ",error,"%\n")
        return False

def Menu():
    #Encabezado
    print("\n\t MÉTODOS NUMERICOS\n\n\tMétodo de falsa posición\n\n")

    while True:

        ecuacion = input("Ingresa la ecuación a evaluar, en terminos de x ---> ")
        xi = float(input("\nIngresa el valor de xi ---> "))
        xu  = float(input("\nIngresa el valor de xu ---> "))

        print("\n\tSelecciona la condición de parada\n\n1.-Por error\n2.-Por iteración")
        opc = input("---> ")

        if opc == "1":
            error_sugerido = float(input("\nIngresa el error sugerido ---> "))
            print("\nIteración\txi\txu\tf(xi)\txr\tf(xr)\tError")
            Biseccion_error(xi,xu,ecuacion,0,0,error_sugerido)
            return False
        if opc == "2":
            iteracion_sugerida = int(input("\nIngrese la iteración en la que se detendra el método ---> "))
            print("\nIteración\txi\txu\tf(xi)\ttxr\tf(xr)\tError")
            Biseccion_iteracion(xi,xu,ecuacion,0,0,iteracion_sugerida)
            return False
        else:
            True

Menu()