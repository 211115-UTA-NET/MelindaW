#!usr/bin/bash


input=./myNewFolder/myNewFile.txt

while IFS= read -r line
do
	echo $line
done < $input

#output=echo cat -t ./myNewFolder/myNewFile.txt
#echo $output

#value=$(<./myNewFolder/myNewFile.txt)
#echo "$value"