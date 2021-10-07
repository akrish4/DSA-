//dfs traversal of undirected graph using recursive approach
#include <bits/stdc++.h>
using namespace std;

void dfs(vector<vector<int>>&adj, vector<int>&v,int x)
{
    v[x]=1;
    cout<<x<<" ";//print the vertex visited 
    for(int i=0;i<adj[x].size();i++)
    {
        if(v[adj[x][i]]==0)
        {
            dfs(adj,v,adj[x][i]);//call the dfs function if a node is not visited
        }
    }
}
int main()
{
    int n,m;
    cin>>n>>m;//enter the number of vertices and number of edges
    vector<vector<int>>adj(n+1,vector<int>());
    //create and adjacency list according to the edges given in input
    for(int i=0;i<m;i++)
    {
        int u,v;
        cin>>u>>v;
        adj[u].push_back(v);
        adj[v].push_back(u);
    }
    cout<<"The dfs traversal is \n";
    vector<int>v(n+1,0);
    dfs(adj,v,1);
    return 0;
}
