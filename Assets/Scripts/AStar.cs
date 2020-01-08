using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AStar
{
    private static Queue<Node> closedQueue, openQueue;

    public static void FindPath(Node startNode, Node endNode)
    {
        // 탐색을 위한 Node를 담을 Queue 설정
        openQueue = new Queue<Node>();
        openQueue.Enqueue(startNode);
        startNode.gScore = 0f;
        startNode.hScore = GetPostionScore(startNode, endNode);

        // 탐색이 끝난 Node를 담을 Queue 설정
        closedQueue = new Queue<Node>();

        Node node = null;

        while (openQueue.Count != 0)
        {
            node = openQueue.Dequeue();

            // Node를 기준으로 갈수있는 주변 길 찾기

        }
    }

    private static float GetPostionScore(Node currentNode, Node endNode)
    {
        Vector3 resultValue = currentNode.position - endNode.position;
        return resultValue.magnitude;
    }
}
