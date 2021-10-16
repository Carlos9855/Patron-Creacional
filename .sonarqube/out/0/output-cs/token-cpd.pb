î	
kC:\Users\josec\Documents\UCB\Arquitectura de Software\Patron_Creacional\FactoryMethod\FactoryMethod\Bass.cs
	namespace 	
FactoryMethod
 
{ 
public 

class 
Bass 
: 
IInstrument #
{ 
public 
string 
Play 
( 
int 
notes $
)$ %
{ 	
string 
result 
= 
$str 7
+8 9
notes: ?
.? @
ToString@ H
(H I
)I J
+K L
$strM U
;U V
return		 
result		 
;		 
}

 	
public 
string 
Sell 
( 
int 
price $
)$ %
{ 	
string 
result 
= 
$str =
+> ?
price@ E
.E F
ToStringF N
(N O
)O P
+Q R
$strS V
;V W
return 
result 
; 
} 	
} 
} Å

ÄC:\Users\josec\Documents\UCB\Arquitectura de Software\Patron_Creacional\FactoryMethod\FactoryMethod\ConcreteInstrumentFactory.cs
	namespace 	
FactoryMethod
 
{ 
public 

class %
ConcreteInstrumentFactory *
:* +
InstrumentFactory, =
{ 
public 
override 
IInstrument #
GetInstrument$ 1
(1 2
string2 8

Instrument9 C
)C D
{ 	
switch 
( 

Instrument 
) 
{		 
case

 
$str

 
:

 
return 
new 
Guitar %
(% &
)& '
;' (
case 
$str 
: 
return 
new 
Piano $
($ %
)% &
;& '
case 
$str 
: 
return 
new 
Bass #
(# $
)$ %
;% &
default 
: 
throw 
new 
	Exception '
(' (

Instrument( 2
)2 3
;3 4
} 
} 	
} 
} ò	
mC:\Users\josec\Documents\UCB\Arquitectura de Software\Patron_Creacional\FactoryMethod\FactoryMethod\Guitar.cs
	namespace 	
FactoryMethod
 
{ 
public 

class 
Guitar 
: 
IInstrument $
{ 
public 
string 
Play 
( 
int 
notes $
)$ %
{% &
string 
result 
= 
$str 9
+: ;
notes< A
.A B
ToStringB J
(J K
)K L
+M N
$strO W
;W X
return 
result 
; 
}		 	
public 
string 
Sell 
( 
int 
price $
)$ %
{% &
string 
result 
= 
$str ?
+@ A
priceB G
.G H
ToStringH P
(P Q
)Q R
+S T
$strU X
;X Y
return 
result 
; 
} 	
} 
} é
rC:\Users\josec\Documents\UCB\Arquitectura de Software\Patron_Creacional\FactoryMethod\FactoryMethod\IInstrument.cs
	namespace 	
FactoryMethod
 
{ 
public 

	interface 
IInstrument  
{ 
string 
Play 
( 
int 
notes 
) 
; 
string 
Sell 
( 
int 
price 
) 
; 
} 
}		 Ù
wC:\Users\josec\Documents\UCB\Arquitectura de Software\Patron_Creacional\FactoryMethod\FactoryMethod\IntrumentFactory.cs
	namespace 	
FactoryMethod
 
{ 
public 

abstract 
class 
InstrumentFactory +
{ 
public 
abstract 
IInstrument #
GetInstrument$ 1
(1 2
string2 8

Instrument9 C
)C D
;D E
} 
}		 ñ	
lC:\Users\josec\Documents\UCB\Arquitectura de Software\Patron_Creacional\FactoryMethod\FactoryMethod\Piano.cs
	namespace 	
FactoryMethod
 
{ 
public 

class 
Piano 
: 
IInstrument $
{ 
public 
string 
Play 
( 
int 
notes $
)$ %
{ 	
string 
result 
= 
$str 8
+9 :
notes; @
.@ A
ToStringA I
(I J
)J K
+L M
$strN V
;V W
return		 
result		 
;		 
}

 	
public 
string 
Sell 
( 
int 
price $
)$ %
{ 	
string 
result 
= 
$str >
+? @
priceA F
.F G
ToStringG O
(O P
)P Q
+R S
$strT W
;W X
return 
result 
; 
} 	
} 
} ›
nC:\Users\josec\Documents\UCB\Arquitectura de Software\Patron_Creacional\FactoryMethod\FactoryMethod\Program.cs
	namespace 	
FactoryMethod
 
{ 
static 

class 
Program 
{ 
static 
void 
Main 
( 
string 
[  
]  !
args" &
)& '
{ 	
InstrumentFactory		 
factory		 %
=		& '
new		( +%
ConcreteInstrumentFactory		, E
(		E F
)		F G
;		G H
string

 
play

 
;

 
string 
sell 
; 
IInstrument 
guitar 
=  
factory! (
.( )
GetInstrument) 6
(6 7
$str7 ?
)? @
;@ A
play 
= 
guitar 
. 
Play 
( 
$num  
)  !
;! "
sell 
= 
guitar 
. 
Sell 
( 
$num "
)" #
;# $
Console 
. 
	WriteLine 
( 
play "
)" #
;# $
Console 
. 
	WriteLine 
( 
sell "
)" #
;# $
IInstrument 
piano 
= 
factory  '
.' (
GetInstrument( 5
(5 6
$str6 =
)= >
;> ?
play 
= 
piano 
. 
Play 
( 
$num  
)  !
;! "
sell 
= 
piano 
. 
Sell 
( 
$num "
)" #
;# $
Console 
. 
	WriteLine 
( 
play "
)" #
;# $
Console 
. 
	WriteLine 
( 
sell "
)" #
;# $
IInstrument 
bass 
= 
factory &
.& '
GetInstrument' 4
(4 5
$str5 ;
); <
;< =
play 
= 
bass 
. 
Play 
( 
$num 
)  
;  !
sell 
= 
bass 
. 
Sell 
( 
$num  
)  !
;! "
Console 
. 
	WriteLine 
( 
play "
)" #
;# $
Console 
. 
	WriteLine 
( 
sell "
)" #
;# $
} 	
}   
}!! 