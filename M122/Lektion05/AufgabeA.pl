# Name ausgeben
# Enea Krähenbühl
# 2021-09-24 13:39:00
# Aufgabe1.pl

use strict;
use warnings;
 
print "Your name please: ";
my $name = <STDIN>;
chomp $name;
 
print "Your surname please: ";
my $surname = <STDIN>;
chomp $surname;

print "Your name is '$name' and your surname is '$surname'\n";