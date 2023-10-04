# Metaheuristics_test
This repository aims to compare the performance of traditional metaheuristics given a simple problem.

The problem consists of a simple vector of 100 positions. Each position can only be filled by the numbers 0 and 10. The goal of each metaheuristic algorithm is to obtain the best possible solution by filling the spaces in this vector with the numbers 0 or 10.

The solution to the problem is given by the sum of all the numbers in the vector (Sum_vector) + 2^(Number of 0's in prime positions in the vector (Prime_pos_0)). 

Initially, a random vector is generated with numbers between 0 and 10, but the number of 0's that can be generated is fixed at six.

Two different approaches to the algorithm were considered (which can be selected by the user). The first approach is the "Choose Metaheuristic", where the algorithm navigates through the generated vector and inserts the value 0 or 10 into a position. The second approach is the "Swap Metaheuristic", where the algorithm swaps the numbers in the position vector, i.e. the number of 0's is fixed at six for all iterations (This approach is still in the testing phase and can be excluded).


Formulating the optimization problem:
  
    Max( Sum_Vector + 2^(Prime_pos_0))


Constraints (so far):

    (amount of 0) in generate_vector <= 6

