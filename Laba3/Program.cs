using System;
using System.Collections.Generic;

class Set
{
    private HashSet<int> elements;

    public Set()
    {
        elements = new HashSet<int>();
    }

    public bool Contains(int element)
    {
        return elements.Contains(element);
    }

    public void Add(int element)
    {
        elements.Add(element);
    }

    public void Remove(int element)
    {
        elements.Remove(element);
    }

    public bool IsSubsetOf(Set otherSet)
    {
        return elements.IsSubsetOf(otherSet.elements);
    }

    public bool Equals(Set otherSet)
    {
        return elements.SetEquals(otherSet.elements);
    }

    public Set Union(Set otherSet)
    {
        Set unionSet = new Set();
        foreach (int element in elements)
        {
            unionSet.Add(element);
        }
        foreach (int element in otherSet.elements)
        {
            unionSet.Add(element);
        }
        return unionSet;
    }

    public Set Intersection(Set otherSet)
    {
        Set intersectionSet = new Set();
        foreach (int element in elements)
        {
            if (otherSet.Contains(element))
            {
                intersectionSet.Add(element);
            }
        }
        return intersectionSet;
    }

    public Set Difference(Set otherSet)
    {
        Set differenceSet = new Set();
        foreach (int element in elements)
        {
            if (!otherSet.Contains(element))
            {
                differenceSet.Add(element);
            }
        }
        return differenceSet;
    }

    public Set SymmetricDifference(Set otherSet)
    {
        Set symmetricDifferenceSet = new Set();

        foreach (int element in elements)
        {
            if (!otherSet.Contains(element))
            {
                symmetricDifferenceSet.Add(element);
            }
        }

        foreach (int element in otherSet.elements)
        {
            if (!elements.Contains(element))
            {
                symmetricDifferenceSet.Add(element);
            }
        }

        return symmetricDifferenceSet;
    }

    // Getter method for elements
    public HashSet<int> GetElements()
    {
        return elements;
    }
}

class Program
{
   
}