**Exercicis iteratives**

1. Escriure els 20 primers números (1, 2, 3,........ 20\)
---     
2. Escriure els 20 primers números parells (2, 4, 6, 8,........ , 40\)  
---
3. Demanar 10 números per teclat i que els sumi
---
4. Escriu un programa que demane un número i mostre la taula de multiplicar de l‘1 al 10\.  
---
5. Demanar 10 enters i dir quants eren positius, quants negatius i quantes vegades hi havia el zero  
---
6. Demanar 2 números i calcular el producte a base se sumes.   
    Per exemple 5 \* 3 \= 5+ 5 \+ 5
---
7. Calcula la divisió entera a base de restes.   
    20 / 3 \= 6 \* 3 \+ 2\. Quocient 3 i sobren 2, doncs puc restar 6 vegades el 3
---
8. Fer un programa que demani un número N i calcule la suma del 1 al N.   
    Per exemple si donem el 4 ha de calcular 1+2+3+4=10
---
9. Fer un programa que demani un número N i escriga els seus divisors.   
    Per exemple si donem el 12 ha d’escriure: 1 2 3 4 6 12
---
10. Fer un programa que compti els divisors d’un número.   
    Per exemple si donem el 12 ha d’escriure: 6
---
11. Fer un programa que digui si un número és primer. Són primers els que tenen només dos divisors, el 1 i ell mateix.  
---
12. Fer un programa que calcule el màxim comú divisor de dos números. El màxim comú divisor és el divisor de tots dos més gran que hi hagi. Si no trobem cap divisor, l’1 sempre ho serà.  
---
13. Fer un programa que calcule el mínim comú múltiple de dos números. El mínim comú múltiple és el múltiple de tots dos més petit que hi hagi. Com a molt, el producte de tots dos ho serà.  
---
14. Dir si un número és perfecte. Ho son els que la suma dels divisors excepte ell mateix coincideix amb el número.   
    Per exemple 6 \= 1 \+ 2 \+ 3
    b. Calcula els 5 primers números perfectes.
---
15. Fer un programa que llanci 1000000 de monedes (s’inventi 0 o 1\) i digui quin % de cares i creus ha tret.  
---
16. Calcular
    | ![image1](https://github.com/user-attachments/assets/29e3b2fa-9252-4ad9-a230-81131b87e962) |
    | :---- |
    
---
17. Fer un programa que diga si un número és apilable: 
    Ho són el 0,1,3,6,10,15, 21, ...  (número anterior \+ iteració actual)
---
18. Fer un programa que escrigui els apilables entre 1 i 1000  
---
19. Fer un programa que escriga els 20 primers termes de la successió de Fibonacci. 
    La successió és 1, 1, 2, 3, 5, 8, 13, 21, 34, ...  els dos primers termes son 1 i 1…
---
20. Donat el polinomi de Taylor per resoldre els cosinus, demanar a l’usuari el valor de la x i el número de termes en que vols aproximar el cosinus seguint la següent fórmula.  
    | ![image3](https://github.com/user-attachments/assets/bf00e17f-41b0-4935-a4cf-8c3ca64d8528) |
    | :---- |
---
21. La següent successió convergeix a , agafant com a primer terme Xo \= n Escriure un algoritme per tal d’obtenir el valor de , donat un n\>=0 llegit per teclat.  
    | ![image2](https://github.com/user-attachments/assets/d4bc1d0a-6efe-4993-8b46-cc346d6a20d0) |
    | :---- |

    L'algorisme finalitzarà quan 2 aproximacions consecutives siguen iguals
---
22. Donat un fitxer amb un conjunt de valors numèrics acabat amb \-1 o final de fitxer, mostra’ls per consola de forma ordenada.   
---
23. Sobre l’anterior exercici indicar el segon major i el segon menor.  
---
24. Donada una seqüència de números acabada en \-1, indicar en quants números tenen el 25 entre les seues xifres per exemple el 14254 té aquesta condició i dir quins números són (podeu concatenar un string)  
---
25. Un professor fa diferents exàmens als seus estudiants, posant a cada estudiant una nota real entre 0 i 10 . El professor, ha encarregat a un alumne trampós que li faci un programa amb C\# per obtenir la nota final d'un estudiant, però l’estudiant ha decidit que el programa funcionarà de la següent forma:  

- Si la nota no està entre 0 i 10 informa que hi ha un error en la nota, la descarta i en demana una altra.
- Fa la mitjana de totes les notes, però sense incloure les notes més petites de 5\.
- Per maquillar el resultat, també exclourà la nota màxima entrada.
- Si la nota màxima és menor que 5 (és a dir, el programa les descartaria totes) , Llavors la nota final que el programa ha de mostrar és un 5 independentment de les notes que hagi tret.
- Si no s'entra cap nota, llavors s'ha de mostrar el missatge "NO HI HAN NOTES"  
    Per exemple, si un alumne ha tret les següents qualificacions en els exàmens:8,5 3,4  
    5,5  
    4,4  
    7,9  
    La seva nota final seria : (5,5+7,9) / 2I la nota descartada seria 8,5  
    Es demana :  
    Donada Una seqüència de nombres reals acabada amb \-1 mostrar :
  - El promig de les notes, descartant la més alta i les menors de 5\.
  - La nota descartada (òbviament la més alta).  
    Tingueu en compte que no sabem quantes notes s'han d'entrar a priori.
---
26. Volem fer un programa per calcular la mitjana de kw hora que hem de pagar a l’empresa Ipertrola per dia.
    Un usuari entrarà les dades i acabarà amb un 0\.  
    - Els kw han de ser positius i si la lectura indica més de 35,3 kw indicar que es un error, tant si és negatiu com si la lectura és massa elevada, les descartem i seguim amb les següents.  
    - Si l’usuari no ha estat a casa i per tant la primera lectura es un 0, direm per consola “Usuari absent”.  
    - Ipertrola no li agraden els valors petits, així que totes les lectures inferiors a 7,3 li afegeix \+ 5kw a l’hora de contabilitzar.  
    - El resultat més petit de tots el treu del recompte, per tant tampoc contarem aquesta lectura.  
    - Finalment el programa ha de mostrar la mitjana de consum que ha tingut l’usuari per consola i ha de tenir emmagatzemada la dada més baixa en una variable per a saber quina ha sigut descartada.
---
27. Fer un programa C\# digui si un ISBN (International Standard Book Number) de 10 elements. El programa ens demanarà un número enter de 9 xifres (int) i el digit de control (char) i si és incorrecte ens ho dirà i ho tornarà a demanar tot.
    El ISBN 843654201-0 és correcte. Per mirar-lo farem  
    8\*1+4\*2+3\*3+6\*4+5\*5+4\*6+2\*7+0\*8+1\*9=121  
    121 MOD 11 \= 0 🡪 dígit de control és 0\. Si fos 10 seria X
---
28. …
