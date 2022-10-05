
from pyswip import Prolog
prolog = Prolog()

print("--------------------")
prolog.assertz('(hermanosxy(X,Y):- progenitorxy(Z,X), progenitorxy(Z,Y), not(X==Y))')
prolog.assertz('(abuelosxy(X,Y) :- progenitorxy(X,Z), progenitorxy(Z,Y))')
prolog.assertz('(nietoxy(X,Y):-  progenitorxy(Z,X),  progenitorxy(Y,Z))')
prolog.assertz('(primosxy(X,Y):- progenitorxy(Z,X), progenitorxy(W,Y), hermanosxy(Z,W))')

prolog.assertz('progenitorxy(williams,luis)')
prolog.assertz('progenitorxy(williams,yohana)')
prolog.assertz('progenitorxy(julio,williams)')
prolog.assertz('progenitorxy(julio,david)')
prolog.assertz('hermanosxy(david,williams)')
prolog.assertz('hermanosxy(williams, david)')
prolog.assertz('progenitorxy(david,jorge)')
print("---------relacion padres-----------")
for soln in prolog.query("progenitorxy(X,Y)"):
    print(soln["X"], " es padre de ", soln["Y"])
print("---------relacion hermanos-----------")
for soln in prolog.query("hermanosxy(X,Y)"):
    print(soln["X"], " es hermano de ", soln["Y"])
print("---------relacion de nietos-----------")
for soln in prolog.query("nietoxy(X,Y)"):
    print(soln["X"], " es nieto  de ", soln["Y"])
print("---------relacion de abuelos-----------")
for soln in prolog.query("abuelosxy(X,Y)"):
    print(soln["X"], "es abuelo de ", soln["Y"])
print("---------relacion de primos-----------")
for soln in prolog.query("primosxy(X,Y)"):
    print(soln["X"], " es primo  de ", soln["Y"])

print("--------------------")



