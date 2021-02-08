Feature: DataTable

Scenario: Horizontal -1
	Given I entered the following data into the new account form horizontal using the section
		| Name        | Birthdate | HeightInInches | BankAccountBalance |
		| John Galt-1 | 2/2/1902  | 72             | 1234.56            |
		| John Galt-2 | 2/2/1902  | 73             | 1000.56            |


Scenario: Horizontal -using modal
	Given I entered the following data into the new account form horizontal using modal
		| Name        | Birthdate | HeightInInches | BankAccountBalance |
		| John Galt-1 | 2/2/1902  | 72             | 1234.56            |

Scenario: Horizontal -using tuple
	Given I entered the following data into the new account form horizontal using tuple
		| Name        | Birthdate | HeightInInches | BankAccountBalance |
		| John Galt-1 | 2/2/1902  | 72             | 1234.56            |

Scenario: vertical-1
	Given I entered the following data into the new account form vertical
		| Field              | Value              |
		| Name               | John Galt Vertical |
		| Birthdate          | 2/2/1902           |
		| HeightInInches     | 100                |
		| BankAccountBalance | 1234.56            |