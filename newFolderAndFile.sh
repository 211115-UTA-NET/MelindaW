
#!user/bin/bash

mkdir myNewFolder

touch ./myNewFolder/myNewFile.txt

echo "Hello, this is my new file!" > ./myNewFolder/myNewFile.txt

for i in {1..20..2}
do
	echo $i >> ./myNewFolder/myNewFile.txt
done

for i in {2..20..2}
do

	nums+=$i
	if(($i<20))
	then
		nums+=", "
	fi
done

echo $nums >> ./myNewFolder/myNewFile.txt