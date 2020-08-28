Context

	- You are given a family tree.  
	- This family tree is made up of people, each with a list of decendants.   
	- Each descendant is unique (we're only tracking one side of the family), and names are not repeated.
	
Given the following example family

				Ted
				 /\
				/  \
			     Jim  Sally
			     /      /\
			    /      /  \
		       Bob    Joe  George

Write a method that, given the person Ted and the string 'Joe' are passed in, will return Joe's birth month in the 'MMMM' format (full month name) 
Once that is complete, augment the method to handle Names that do not exist in the family tree.

#####
NOTE: I think a requirement (could be hidden) that searching for someone that isn't a direct descendant should return empty as well. I added a test for this, maybe it's something you already do. For example, given person Sally and name Ted should return empty because Ted isn't a descendant of Sally.
#####

Keep in mind that the tree supplied above is just an example.  Your solution should be able to solve for any person/tree and any string name.

Feel free to add/remove anything from this Solution that will help you in solving the problem.  Comments are appreciated to explain thought process.
