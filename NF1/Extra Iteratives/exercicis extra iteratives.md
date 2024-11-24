**Exercicis iteratives**

1. Escriure els 20 primers números (1, 2, 3,........ 20\)  
2. Escriure els 20 primers números parells (2, 4, 6, 8,........ , 40\)  
3. Demanar 10 números per teclat i que els sumi  
4. Escriu un programa que demane un número i mostre la taula de multiplicar de l‘1 al 10\.  
5. Demanar 10 enters i dir quants eren positius, quants negatius i quantes vegades hi havia el zero  
6. Demanar 2 números i calcular el producte a base se sumes. 

Per exemple 5 \* 3 \= 5+ 5 \+ 5

7. Calcula la divisió entera a base de restes. 

20 / 3 \= 6 \* 3 \+ 2\. Quocient 3 i sobren 2, doncs puc restar 6 vegades el 3

8. Fer un programa que demani un número N i calcule la suma del 1 al N. 

Per exemple si donem el 4 ha de calcular 1+2+3+4=10

9. Fer un programa que demani un número N i escriga els seus divisors. 

Per exemple si donem el 12 ha d’escriure: 1 2 3 4 6 12

10. Fer un programa que compti els divisors d’un número. 

Per exemple si donem el 12 ha d’escriure: 6

11. Fer un programa que digui si un número és primer. Són primers els que tenen només dos divisors, el 1 i ell mateix.  
12. Fer un programa que calcule el màxim comú divisor de dos números. El màxim comú divisor és el divisor de tots dos més gran que hi hagi. Si no trobem cap divisor, l’1 sempre ho serà.  
13. Fer un programa que calcule el mínim comú múltiple de dos números. El mínim comú múltiple és el múltiple de tots dos més petit que hi hagi. com a molt, el producte de tots dos ho serà.  
14. Dir si un número és perfecte. Ho son els que la suma dels divisors excepte ell mateix coincideix amb el número. 

Per exemple 6 \= 1 \+ 2 \+ 3

b. Calcula els 5 primers números perfectes.

15. Fer un programa que llanci 1000000 de monedes (s’inventi 0 o 1\) i digui quin % de cares i creus ha tret.  
16. Calcular 

| ![][image1] |
| :---- |

    

18. Fer un programa que diga si un número és apilable: 

Ho són el 0,1,3,6,10,15, 21, ...  (número anterior \+ iteració actual)

19. Fer un programa que escrigui els apilables entre 1 i 1000  
20. Fer un programa que escriga els 20 primers termes de la successió de Fibonacci. 

La successió és 1, 1, 2, 3, 5, 8, 13, 21, 34, ...  els dos primers termes son 1 i 1…

21. Donat el polinomi de Taylor per resoldre els cosinus, demanar a l’usuari el valor de la x i el número de termes en que vols aproximar el cosinus seguint la següent fórmula.

| ![][image2] |
| :---: |

22. La següent successió convergeix a , agafant com a primer terme Xo \= n Escriure un algoritme per tal d’obtenir el valor de , donat un n\>=0 llegit per teclat.

![][image3]  
L’algoritme finalitzarà quan 2 aproximacions consecutives siguin iguals.

23. Donat un fitxer amb un conjunt de valors numèrics acabat amb \-1 o final de fitxer, mostra’ls per consola de forma ordenada.   
24. Sobre l’anterior exercici indicar el segon major i el segon menor.  
25. Donada una seqüència de números acabada en \-1, indicar en quants números tenen el 25 entre les seues xifres per exemple el 14254 té aquesta condició i dir quins números són (podeu concatenar un string)  
26. Un professor fa diferents exàmens als seus estudiants, posant a cada estudiant una nota real entre 0 i 10 . El professor, ha encarregat a un alumne trampós que li faci un programa amb C\# per obtenir la nota final d'un estudiant , però l’estudiant ha decidit que el programa funcionarà de la següent forma:

• Si la nota no està entre 0 i 10 informa que hi ha un error en la nota, la descarta i en demana una altra.  
• Fa la mitjana de totes les notes, però sense incloure les notes més petites de 5\.  
• Per maquillar el resultat, també exclourà la nota màxima entrada .  
• Si la nota màxima és menor que 5 (és a dir, el programa les descartaria totes) , Llavors la nota final que el programa ha de mostrar és un 5 independentment de les notes que hagi tret.  
• Si no s'entra cap nota, llavors s'ha de mostrar el missatge "NO HI HAN NOTES"  
Per exemple, si un alumne ha tret les següents qualificacions en els exàmens:8,5 3,4  
5,5  
4,4  
7,9  
La seva nota final seria : (5,5+7,9) / 2I la nota descartada seria 8,5  
Es demana :  
Donada Una seqüència de nombres reals acabada amb \-1 mostrar :  
• El promig de les notes, descartant la més alta i les menors de 5\.  
• La nota descartada (òbviament la més alta).  
Tingueu en compte que no sabem quantes notes s'han d'entrar a priori.

27. Volem fer un programa per calcular la mitjana de kw hora que hem de pagar a l’empresa Ipertrola per dia.

Un usuari entrarà les dades i acabarà amb un 0\.  
\- Els kw han de ser positius i si la lectura indica més de 35,3 kw indicar que es un error, tant si és negatiu  
com si la lectura és massa elevada, les descartem i seguim amb les següents.  
\- Si l’usuari no ha estat a casa i per tant la primera lectura es un 0, direm per consola “Usuari absent”.  
\- Ipertrola no li agraden els valors petits, així que totes les lectures inferiors a 7,3 li afegeix \+ 5kw a l’hora  
de contabilitzar.  
\- El resultat més petit de tots el treu del recompte, per tant tampoc contarem aquesta lectura.  
\- Finalment el programa ha de mostrar la mitjana de consum que ha tingut l’usuari per consola i ha de  
tenir emmagatzemada la dada més baixa en una variable per a saber quina ha sigut descartada.

28. Fer un programa C\# digui si un ISBN (International Standard Book Number) de 10 elements. El programa ens demanarà un número enter de 9 xifres (int) i el digit de control (char) i si és incorrecte ens ho dirà i ho tornarà a demanar tot.

El ISBN 843654201-0 és correcte. Per mirar-lo farem  
8\*1+4\*2+3\*3+6\*4+5\*5+4\*6+2\*7+0\*8+1\*9=121  
121 MOD 11 \= 0 🡪 dígit de control és 0\. Si fos 10 seria X

29. …

    

[image1]: <data:image/png;base64,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>

[image2]: <data:image/png;base64,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>

[image3]: <data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAJUAAAAaCAIAAAAxJokVAAAFQ0lEQVR4Xu2XbUwURxjHZ/blrgLCYTUqhIJQD5BQMJh+KWqg0cS0BikoaW1MCKVvaYtFEGJta9o0bZqapu+pTYwgFkWKJJRK1JpT02spVmIkTZu20BBBNHg1ubvcXfY222d3D253bu/Yo5Bmk/19mvnv3DzPzH/eDgkmRgZ5vd4MEwNSWloq+ud2u0lPTYxAfn6+YPpnXEz/jI3pn7Ex/TM2pn/GxvTP2Jj+GRvTP2MTy7/qFRRCaOeJW3K1vSYTqrvaR9Wt5s+OdObpzl86qlcgRN3iZY3LZDHC7GhQ3TQuAr8xmB0PdagLbuQdamVNqMJPicPWlZKbQkxAlyiiiiLRvDUbImEm1XE7nnQVxPKPn+qoAgupFMh86L0yiJRb30s2mi8nn8pIfPiQWJLmK2XrZ1AsWwZF3Ds512B8PQkJCS5SleEzGHxoyEfKMXkkAXdMhYNKw9aVUjGLWn4izdIUBTKK/0qjHXruvDr25FoW0WnKlvqJ5R+s5J9fK4IYDm8wS1yD9IifbBGNwd7TXQq+uTLGqb7zaTRqcXrlShGLMWMP/v01RoheuU3VUBNvFywmTf/4yU6ELaF+Q5Lrxrnu0z3OwITzudrai+ORM3uPxqxSFYetL6XKRLzp8JgekYwScDblMYjOhuLIWyUIseGG8RDbP8APxkng41onSDR2i8s2jHXbV8rp/v3wZsTkzVb9gwdCMdhMXTGi+7c5Eec1O5UKN9hawCAqOXXJ6kIbDavQSoQ4+2xWQcuPak1vSi3rGHbjB3pEzSgyG1MozK4nVX3M6Z9wsMQCw9jdNRmqc8OILVS1kHBf/9Ja9jGpRiGTRoUHhhSC1yKuEnr2lBp+oxgaqLesCLEsEOGi/wIoxM/O1qfTCNm2fAplZ3MerHT1dzdcllqnra6UXlpDM/ZX1ZqmGC2KUJu3BBbJt4tx/8HJ42jdIE8Tnb5H1rhfu98+MSyW/APMg3tlcbs9GdrsOhnuJNb+42/CzHw+8zyA+oaloT2+p+euLHW/++ZwjLNae//xNz8ph+1FzERVitj5EWmCnn+AxpZNio+eiy+vtTc4FIqIOGx9KZWwKKmibU5RMwpQncWCeadGIxeqXmL4x+daxTEkFjeef1F8JnVKU9C501Z5/HZqMpCIaUtyciq0vBMQSln0vWJ4QY4LKOCCiln190NvN6Sc+ckzz+Raodp4YTqbgUffKrmdDeN/wj+IQNs/f39dGmJL1CIvDYKS1z5YuXRH++y3y3vtDGY8s3UJSEm2TkdKftjZ+8mnSqTojYwi3HPsL04A8/rC63g+RPWvKoMVx728XKp54BaklldC6VEr7pd9Uuw/uI4Z8lyKDncNeh6DtLk/5cu1/P2rIHscDVCuPDYp8BN4Pu8x7trBIqTaXqBdFwMwuWKZH4dodaHsAR+L6ewXzoUbCzMpwbB1pOT5rh5RNmL6I0TfD035ZBRBeCJVdT41OSNfVbrQ9o+/MwCjwEnr952flpXHIZ50gq+icGjFKP2DI5FaHSrPjQtL+2+g4SExd5w0LXfIj8OY2HXNgq8P37eF+I0eXEe3k/vv7jExgq1aLHvPQPmLmfXOTxzFSWUf/qF6ncgpicPWkdKRx2xs/r7YIkSpWEYRUYD71fe44uaJD23/ouPClI3UxJX/OlPQSqrRgT8PH0X/g+1qq7DVnCJVPfj64c9D1H7/AxopuS9jzJLPDk1xMYnXv4Whry4955VLpLoQwFvz0jyPorgIZjC47S9iV2mKi8v/45/JQmH6Z2xC/nk8HouJAcnJyRH9I201MRT/AqYIfRWAEcpmAAAAAElFTkSuQmCC>