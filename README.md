# HybridizationTool
Tool for testing suitability of siRNA sequences within a given cellular environment. Uses blastn and RNAfold programs.

## What does it do?
When designing a logic evaluator in cells, one of the ways to do this is by using siRNA.
siRNA are short RNA sequences which, when bound to their complementary target sequence on a transcript, will cleave the transcript and prevent it from being translated.
One of the tricky prts in designing a logic analyzer using siRNA is that the siRNA could bind to sites that we do not want them to bind to, or choosing the wrong sequence of nucleotides for the siRNA strand could result in the siRNA folding into a secondary structure.
In order to prevent these things, we can use blastn and RNAfold to determine whether the siRNA is suitable.

### Blast+
The program blastn, which comes in the Blast+ package of programs from NCBI (Download here: ftp://ftp.ncbi.nlm.nih.gov/blast/executables/blast+/LATEST/), allows us to search a database of genes to determine whether our target sequence is similar or identical to them.

### RNAfold
The program RNAfold can be found in the ViennaRNA Package (Download here: https://www.tbi.univie.ac.at/RNA/) and is used for predicting secondary structures of RNA sequeneces.

## How does it work?
+ Once both the Blast+ and ViennaRNA packages have been installed, you must find the blastn.exe and RNAfold.exe files and select them in the HybridizationTool.
+ Blastn also requires you to have downloaded a database from the NCBI ftp site (Download here: ftp://ftp.ncbi.nlm.nih.gov/blast/db/).
+ The target sequences are fed into the program using files in the ".fasta" format.
+ Each target sequence is tested individually using the "Test Part" button on the bottom right corner of the program window.
+ When the tests have been done, The program will report the status of each sequence, whether or not it passes or fails the test.
+ In order to pass the blastn test, ther must not be any matches with an e-value of 1e-3 or lower, e-values higher than this are considered insignificant.
+ In order to pass the RNAfold test, no secondary structures must have been found.
