sudo apt install zsh

sudo yum install zsh

sudo apt install vim

EDITOR=vim

crontab e

MYVAR=pluralsight

set | grep MYVAR

export MYENV=utah

env | grep MYENV

declare -p MYVAR MYENV

declare -l fruit=Apple

declare -p fruit

declare -l fruit="apple"

unset fruit

declare -u fruit=Apple

declare -p fruit

declare -u fruit="APPLE"

declare -r name=bob

name=fred
bash: name: readonly variable

declare -i days=30

days=Monday

declare -p days

declare i days="0"

declare -a user_name

user_name [0]=bob ; user_name [1]=smith

echo ${user_name [0]}
    bob

unset user_name ; declare -A user_name

user_name =([first]=bob [last]=smith)

$ echo ${user_name [first])
    bob

echo hello || echo bye
    hello

echo hello && echo bye
    hello
    goodbye

declare -i days=30

if [ $days -lt 1 ] ;then echo "Enter correct value"; fi

declare -i days=Monday

if [ $days -lt 1 ] ;then echo "Enter correct value"; fi
    Enter correct value    

declare -i days=31

if [ $days -lt 1 ] || [ $days -gt 30 ] ;
then echo "Enter correct value"; fi
    Enter correct value

declare -i days=31

if ((days < 1 || days > 30));
then echo "Enter correct value"; fi
    Enter correct value

declare -i days=30
if ((days < 1 || days > 30));
then echo "Enter correct value"; else echo "All good"; fi
All good


declare -i days

read days
    Monday

if ((days < 1 )); then echo "Enter numeric value";

elif ((days > 30 )); then echo "Too high" ;

else echo "The value is $days" ; fi
    Enter numeric value

declare -l user_name

read user_name
    Bob

[ $user_name == 'bob' ] && echo "user is bob"
    user is bob


declare -l browser

read browser
    Firefox

[[ $browser == *fox ]] && echo "The browser's Firefox"
    The browser's Firefox

declare -l test_var

read test_var
    color

[[ $test_var colou?r ]] && echo "${BASH_REMATCH[0]}"
    color

type test [ [[

test is a shell builtin
[ is a shell builtin
[[ is a shell keyword

test -f /etc /hosts && echo YES
YES

[[ -f / etc /hosts ]] && YES
YES

-f
To test for a regular file
[[ -f /etc/hosts ]]

-d
Tests for a directory
[[-d /etc]]

-L
Tests for symbolic link
[[ -L /etc/localtime]] 

-e
For the existence of a file no matter the type
[[-e /etc/nologin]]

-r
Tests for the read permission, r = read, w = write,
[[-r /etc/hosts]]

-k
Tests for the sticky bit
[[-k /tmp]]

-s
Tests for the SUID bit, use g for the GUID bit
[[-s /bin/passwd]]

case $USER in
    tux )
        echo "You are cool"
        ;;
    root )
        echo "You are the boss"
        ;;
esac

function say_hello() {
echo hello
}

say_hello
    hello

declare -f
declare -F
declare -f say_hello
say_hello() 
{ 
    echo hello
}

create_user tux

function create_user() { 
    if ( getent passwd $1 > /dev/null ); then
        echo "$1 already exists";
        return 1;
    else
        echo "Creating user $1";
        sudo useradd$1;
        return 0;
    fi
}


function print_age() {
    echo $age
}

unset age ; 
unset -f print_age
function print_age() {
    local age=$1
    echo $age
}


List functions:
    detailed: declare -f
    summary: declare -F
Export function:
    declare -fx function_name
Unset function:
    unset -f function_name



declare -i x=10

while (( x > 0 )) ; do
    echo $x
    x=x 1
done


declare -i x=10
until (( x == 0 )) ; do
    echo $x
    x=x 1
done

$ for ((i =0 ; i <5 ; i ++)); do
    echo $i
done

for ((i =5 ; i >0 ; i--)); do echo i ; done


declare -a users=users=("bob" joe" "sue")
echo ${#users[*]}

for ((i =0; i <${#users[*]}; i ++)); do
    sudo useradd ${ users[$i]};
done

for f in $(ls); do stat -c "%n %F" $f ; done


for file in $(ls); do
    if[[ -d $file ]]; then
        continue
    fi
    echo $file
done

foreach f (*)

foreach> echo $f
foreach> end


sudo apt search ^bash$

shopt
shopt autocd

shopt-s autocd; /etc

shopt-s cdspell; cd /ect(misspelled directory)

shopt restricted_shell
    restricted_shell off

rbash

shopt restricted_shell
    restricted_shell on

cd /etc

set -o noclobber

set -C

set +o noclobber( set +C )

ls /etc/*.conf
set -f
ls /etc/*.conf
set +f

type let

let a=3*5
echo $a

type expr 
    expris hashed (/usr/bin/expr)
$ expr 3 * 5
    15
$ b=$(expr 3 * 5)
$ echo $b
    15

$ echo $(( 3 * 5))
    15
$ daily_rate=3 ; rate=2

$ (( rate < daily_rate)) && echo OK
    OK

$ declare -a user_name
$ user_name[0]=bob ; user_name[1]=smith
$ echo ${user_name[0]}bob
$ unset user_name; declare -A user_name
$ user_name=([first]=bob [last]=smith)
$ echo ${user_name[first]}bob


$ ls /etc/hosts
    /etc/hosts (STDOUT)
$ ls /etc/host
ls: cannot access '/etc/host': No such file or directory (STDERR)
$ ls /etc/hosts /etc/host &>file1

( ls/etc/hosts ; ls/etc/host ) > file1ls: cannot access '/etc/host': No such file or directory
$ bash > output

LOG=log.file
$ exec 4>&1
$ exec > "$LOG"
$ ls
$ exec 1>&4 4>&-

cat > myfile <<END
This is line 1
This is line 2
END

$ username="josmith"
$ printf "The user is %s\n" $username
    The user is jo
    The user is smith
$ printf"The user is %s\n" "$username"
    The user is jo smith

type -a echo printf 
echo is a shell builtin
echo is /bin/echo
    printf is a shell builtin
    printf is /usr/bin/printf

cat list1 
    jane
    bob
$ cat list2 
    bob
    jack
$ comm -3 <(sort list1 | uniq) <(sort list2 | uniq)
    jane
    jack

$ cat > my.sh<<END
    echo "This is a script"
END
$ file my.sh
my.sh: ASCII test
$ sed-i'1 i\#!/bin/bash' my.sh; file my.sh
edit.sh: Bourne-Again shell script, ASCII text executable

set -x (or set -o xtrace)
$ ls$HOME
+ ls--color=auto /home/pi

type -a pwd
pwd is a shell builtin
pwd is /bin/pwd
$ which -a pwd
/bin/pwd

./myscript.shfredjones staff$0 $1 $2 $3
$# = 3
$0 = ./myscript.sh
$* = "fredjones staff"
$@ = ("fred" "jones" "staff")


cat script.sh
printf"The script is: %s\n" "$0"
printf"The number of arguments is: %d\n" "$#"
printf"The arguments list is: %s\n" "$*"
printf"The arguments as an array are: %s\n" "$@"

cat shift.sh
fname="$1"
shift
lname="$1"
printf"First: %s Last: %s\n" "$fname" "$lname"

cat shift1.sh
while (( "$#" ))
do
    echo "$1"
    shift
done


while getopts':c:d:' opt
do 
    case "$opt" in
    c) sudo useradd -m "$OPTARG" 
        break ;;
    d) sudo userdel-r "$OPTARG"
        break ;;
    *) echo "Usage: $0 [-c|-d] <user>" ;;
    esac
done

getoptscd -cd
getoptsc:d-c fred-d
getoptsc:d: -c fred-d joe
getopts:cd -h

getopts.sh-c --fred
getopts.sh-d --fred


$ read
    Populates $REPLY
$ read myvar
    Populates $myvar
$ read -s
    Populates $REPLY but does not echo to the screen
$ read -n1 
    Populates $REPLY but only accepts 1 character

$ read -p "Enter a user name: " username
fconstantine
$ echo ${#username}
12

read username
$ echo ${username:-misconfigured}misconfigured
$ unset username
$ read username
$ echo ${username-misconfigured}

echo $SSH_CLIENT192.168.0.97 61908 22
$ echo ${SSH_CLIENT/0/9}192.168.9.97 61908 22
$ echo ${SSH_CLIENT//0/9}192.168.9.97 61998 22

sleep 1000& ; ps-fp$(pgrepsleep)
exit; LOGIN AGAIN:

ps-fp$(pgrepsleep)

$ at noon
-/home/pi/my.sh
-CTRL + d
$ crontab-e
0 12 * * * /home/pi/my.sh

sudo mkfifo /var/log/pipe ; sudochmod666 /var/log/pipe
TERM1 $ echo hello > /var/log/pipe
TERM2 $ cat < /var/log/pipe
hello


#!/bin/bash
declare -l line
until [[ $line == 'stop' ]]
    do 
    line=$(cat /var/log/pipe)
    echo $line >> /var/log/pipe.out
done




