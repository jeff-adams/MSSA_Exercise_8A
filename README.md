# Roulette Winning Bets

> Randomly choose the winning number on a roulette wheel and find all the winning bets

### Implimenation
I created a "bin" object to represent each number on the roulette wheel. This allowed me capture and hold more information during the creation of each number.

I utilized two different arrays to hold each bin. I created one array to hold **roulette wheel order** of bins and another to hold the **numerical table order** of bins. I randomly chose a number from the "wheel" array and then calculated the winning bets using the table array and math.

### Learning Experience
I implemented `Xunit` to test the three more complicated winning calculations. This was the most time consuming portion as I was returning a list and had to evaluate each element in the same order.

I also utilized `Linq` as I have been trying to get more familiar with it, as well as lambdas. One area it especially helped was calculating some statistics during use.

