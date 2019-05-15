#Funciones para el método de Gauss simple

def PrimeraIteracion(matriz,constantes):

    multiplo = matriz[1][0]/matriz[0][0]

    matrizTemporal = [[0,0,0],[0,0,0],[0,0,0]]
    constantesTemporal = [0,0,0]

    matrizTemporal[0][0] = multiplo*matriz[0][0]
    matrizTemporal[0][1] = multiplo*matriz[0][1]
    matrizTemporal[0][2] = multiplo*matriz[0][2]
    constantesTemporal[0] = multiplo*constantes[0]

    matriz[1][0] = matrizTemporal[0][0] - matriz[1][0]
    matriz[1][1] = matrizTemporal[0][1] - matriz[1][1]
    matriz[1][2] = matrizTemporal[0][2] - matriz[1][2]
    constantes[1] = constantesTemporal[0] - constantes[1]

    return matriz,constantes

def SegundaIteracion(matriz,constantes):

    multiplo = matriz[2][0]/matriz[0][0]

    matrizTemporal = [[0,0,0],[0,0,0],[0,0,0]]
    constantesTemporal = [0,0,0]

    matrizTemporal[0][0] = multiplo*matriz[0][0]
    matrizTemporal[0][1] = multiplo*matriz[0][1]
    matrizTemporal[0][2] = multiplo*matriz[0][2]
    constantesTemporal[0] = multiplo*constantes[0]

    matriz[2][0] = matrizTemporal[0][0] - matriz[2][0]
    matriz[2][1] = matrizTemporal[0][1] - matriz[2][1]
    matriz[2][2] = matrizTemporal[0][2] - matriz[2][2]
    constantes[2] = constantesTemporal[0] - constantes[2]

    return matriz,constantes

def TerceraIteracion(matriz,constantes):

    multiplo = matriz[2][1]/matriz[1][1]

    matrizTemporal = [[0,0,0],[0,0,0],[0,0,0]]
    constantesTemporal = [0,0,0]

    matrizTemporal[1][1] = multiplo*matriz[1][1]
    matrizTemporal[1][2] = multiplo*matriz[1][2]
    constantesTemporal[1] = multiplo*constantes[1]

    matriz[2][1] = matrizTemporal[1][1]-matriz[2][1]
    matriz[2][2] = matrizTemporal[1][2]-matriz[2][2]
    constantes[2] = constantesTemporal[1]-constantes[2]

    return matriz,constantes

def XValue(matriz,constantes):
    constantes[2] = constantes[2]/matriz[2][2]
    constantes[1] = (constantes[1]-matriz[1][2]*constantes[2])/matriz[1][1]
    constantes[0] = (constantes[0] + matriz[0][1]*constantes[1] + matriz[0][2]*constantes[2])/matriz[0][0]
    return constantes

