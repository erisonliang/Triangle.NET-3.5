﻿
namespace TriangleNet.Meshing
{
    using System.Collections.Generic;
    using TriangleNet.Topology;
    using TriangleNet.Geometry;

    /// <summary>
    /// Mesh interface.
    /// </summary>
    public interface IMesh
    {
        /// <summary>
        /// Gets the vertices of the mesh.
        /// </summary>
        ICollection<Vertex> Vertices { get; }

        /// <summary>
        /// Gets the dictionary of vertices of the mesh
        /// </summary>
        IDictionary<int, Vertex> VerticesDict { get; }

        /// <summary>
        /// Gets the edges of the mesh.
        /// </summary>
        IEnumerable<Edge> Edges { get; }

        /// <summary>
        /// Gets the segments (constraint edges) of the mesh.
        /// </summary>
        ICollection<SubSegment> Segments { get; }

        /// <summary>
        /// Gets the triangles of the mesh.
        /// </summary>
        ICollection<Triangle> Triangles { get; }

        /// <summary>
        /// Gets the holes of the mesh.
        /// </summary>
        IList<Point> Holes { get; }

        /// <summary>
        /// Gets the bounds of the mesh.
        /// </summary>
        Rectangle Bounds { get; }

        /// <summary>
        /// Renumber mesh vertices and triangles.
        /// </summary>
        void Renumber();

        /// <summary>
        /// Refine the mesh.
        /// </summary>
        void Refine(QualityOptions quality);
    }
}