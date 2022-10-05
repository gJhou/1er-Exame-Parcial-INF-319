def suma(a, b):
    return a+b
    
def resta(a, b):
    return a-b

def multi(a, b):
    return a*b
    
def division(a, b):
    return a/b
  

n1=float(input("Ingrese el primer numero"))
n2=float(input("Ingrese el segundo numero"))

print("1.- Suma")
print(n1, "+", n2, "=", suma(n1, n2))
print("2.- Resta")
print(n1, "-", n2, "=", resta(n1, n2))
print("3.- Multiplicacion")
print(n1, "*", n2, "=", multi(n1, n2))
print("4.- Division")
print(n1, "/", n2, "=", division(n1, n2))



