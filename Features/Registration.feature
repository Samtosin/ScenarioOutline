Feature: Registration

Feature: My Feature
  Scenario Outline: validate a user can register on the website
    Given i navigate to the website 
    And i enter firstname "<firstname>"
    And i enter lastname "<lastname>"
	And i enter email "<email>"
    And i enter the height "<height>"
    And i entered location "<location>"
	And i enter hobbies "<hobbies>"
    And i select career progression "<career>"
    When i click submit
	Then i should be register successfully

    Examples:
      | firstname | lastname | email                 | height | location | hobbies | career           |
      | Sam       | Dun      | rewivov239@lukaat.com | 176    | London   | Reading | Business Analyst |
      | John      | Kelly    | rewivov238@lukaat.com | 156    | Canada   | Singing | Scrum Master     |
      | Idris     | Abel     | rewivov237@lukaat.com | 146    | Nigeria  | Gaming  | Software Testing |

    


	
