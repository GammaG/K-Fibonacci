using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_Fibonacci
{
   class Fibonacci {

    List<int> cache = new List<int>();
       
    private int k;

    public Fibonacci(int k) {
        this.k = k;

        // Bootstrap the cache
        
        cache.Add(1);
        for (int i = 1; i <= k; i++)
            cache.Add(1 << (i-1));
    }

    public long fib(int n) {

        // Extend cache until it includes value for n.
        // (If we've already computed a value for n, we won't loop at all.)
        for (int i = cache.Count; i <= n; i++)
            
            cache.Add(2 * cache[i-1] - cache[i-k-1]);

        // Return cached value.
        return cache[n];
    }
   }
}
