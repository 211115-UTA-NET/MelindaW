
#!user/bin/bash

echo "Enter in the file you want to push to reop."
read userInput

ext="${userInput##*.}"

if [ $ext == "txt" ] || [ $ext == "md" ] || [ $ext == "sh" ] || [ $ext == "png" ]
then

	git add $userInput

	git commit -m "This is the file I made."

	git push
else
	echo "File type is not allowed!"
fi