﻿namespace System.IO.Abstractions
{
    /// <inheritdoc cref="Path" />
    public interface IPath
    {
        /// <inheritdoc cref="Path.AltDirectorySeparatorChar"/>
        char AltDirectorySeparatorChar { get; }
        /// <inheritdoc cref="Path.DirectorySeparatorChar"/>
        char DirectorySeparatorChar { get; }
        /// <summary>
        /// Exposes the underlying filesystem implementation. This is useful for implementing extension methods.
        /// </summary>
        IFileSystem FileSystem { get; }
        /// <inheritdoc cref="Path.PathSeparator"/>
        char PathSeparator { get; }
        /// <inheritdoc cref="Path.VolumeSeparatorChar"/>
        char VolumeSeparatorChar { get; }
        /// <inheritdoc cref="Path.InvalidPathChars"/>
        char[] InvalidPathChars { get; }
        /// <inheritdoc cref="Path.ChangeExtension"/>
        string ChangeExtension(string path, string extension);
        /// <inheritdoc cref="Path.Combine(string[])"/>
        string Combine(params string[] paths);
        /// <inheritdoc cref="Path.Combine(string,string)"/>
        string Combine(string path1, string path2);
        /// <inheritdoc cref="Path.Combine(string,string,string)"/>
        string Combine(string path1, string path2, string path3);
        /// <inheritdoc cref="Path.Combine(string,string,string,string)"/>
        string Combine(string path1, string path2, string path3, string path4);
        /// <inheritdoc cref="Path.GetDirectoryName(string)"/>
        string GetDirectoryName(string path);
        /// <inheritdoc cref="Path.GetExtension(string)"/>
        string GetExtension(string path);
        /// <inheritdoc cref="Path.GetFileName(string)"/>
        string GetFileName(string path);
        /// <inheritdoc cref="Path.GetFileNameWithoutExtension(string)"/>
        string GetFileNameWithoutExtension(string path);
        /// <inheritdoc cref="Path.GetFullPath(string)"/>
        string GetFullPath(string path);
#if FEATURE_ADVANCED_PATH_OPERATIONS
        /// <inheritdoc cref="Path.GetFullPath(string, string)"/>
        string GetFullPath(string path, string basePath);
#endif
        /// <inheritdoc cref="Path.GetInvalidFileNameChars"/>
        char[] GetInvalidFileNameChars();
        /// <inheritdoc cref="Path.GetInvalidPathChars"/>
        char[] GetInvalidPathChars();
        /// <inheritdoc cref="Path.GetPathRoot(string)"/>
        string GetPathRoot(string path);
        /// <inheritdoc cref="Path.GetRandomFileName"/>
        string GetRandomFileName();
        /// <inheritdoc cref="Path.GetTempFileName"/>
        string GetTempFileName();
        /// <inheritdoc cref="Path.GetTempPath"/>
        string GetTempPath();
        /// <inheritdoc cref="Path.HasExtension(string)"/>
        bool HasExtension(string path);
        /// <inheritdoc cref="Path.IsPathRooted(string)"/>
        bool IsPathRooted(string path);

#if FEATURE_ADVANCED_PATH_OPERATIONS
        /// <inheritdoc cref="Path.IsPathFullyQualified(string)"/>
        bool IsPathFullyQualified(string path);

        /// <inheritdoc cref="Path.GetRelativePath(string,string)"/>
        string GetRelativePath(string relativeTo, string path);
#endif

#if FEATURE_PATH_JOIN_WITH_SPAN
        /// <inheritdoc cref="Path.Join(ReadOnlySpan{char},ReadOnlySpan{char})"/>
        string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2);

        /// <inheritdoc cref="Path.Join(ReadOnlySpan{char},ReadOnlySpan{char})"/>
        string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3);

        /// <inheritdoc cref="System.IO.Path.TryJoin(ReadOnlySpan{char}, ReadOnlySpan{char}, ReadOnlySpan{char}, Span{char}, out int)"/>
        bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3, Span<char> destination, out int charsWritten);

        /// <inheritdoc cref="System.IO.Path.TryJoin(ReadOnlySpan{char}, ReadOnlySpan{char}, ReadOnlySpan{char}, Span{char}, out int)"/>
        bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, Span<char> destination, out int charsWritten);
#endif

#if FEATURE_ADVANCED_PATH_OPERATIONS
        /// <inheritdoc cref="System.IO.Path.HasExtension(ReadOnlySpan{char})"/>
        bool HasExtension(ReadOnlySpan<char> path);

        /// <inheritdoc cref="System.IO.Path.IsPathFullyQualified(ReadOnlySpan{char})"/>
        bool IsPathFullyQualified(ReadOnlySpan<char> path);

        /// <inheritdoc cref="System.IO.Path.IsPathRooted(ReadOnlySpan{char})"/>
        bool IsPathRooted(ReadOnlySpan<char> path);

        /// <inheritdoc cref="System.IO.Path.GetDirectoryName(ReadOnlySpan{char})"/>
        ReadOnlySpan<char> GetDirectoryName(ReadOnlySpan<char> path);

        /// <inheritdoc cref="System.IO.Path.GetExtension(ReadOnlySpan{char})"/>
        ReadOnlySpan<char> GetExtension(ReadOnlySpan<char> path);

        /// <inheritdoc cref="System.IO.Path.GetFileName(ReadOnlySpan{char})"/>
        ReadOnlySpan<char> GetFileName(ReadOnlySpan<char> path);

        /// <inheritdoc cref="System.IO.Path.GetFileNameWithoutExtension(ReadOnlySpan{char})"/> 
        ReadOnlySpan<char> GetFileNameWithoutExtension(ReadOnlySpan<char> path);

        /// <inheritdoc cref="System.IO.Path.GetPathRoot(ReadOnlySpan{char})"/> 
        ReadOnlySpan<char> GetPathRoot(ReadOnlySpan<char> path);

#endif

#if FEATURE_PATH_JOIN_WITH_PARAMS
        /// <inheritdoc cref="System.IO.Path.Join(string,string)" />
        string Join(string path1, string path2);

        /// <inheritdoc cref="System.IO.Path.Join(string?, string?, string?)" />
        string Join(string path1, string path2, string path3);

        /// <inheritdoc cref="System.IO.Path.Join(string?[])" />
        string Join(params string[] paths);
#endif

#if FEATURE_ENDS_IN_DIRECTORY_SEPARATOR
        /// <inheritdoc cref="System.IO.Path.EndsInDirectorySeparator(ReadOnlySpan{char})"/>
        bool EndsInDirectorySeparator(ReadOnlySpan<char> path);

        /// <inheritdoc cref="System.IO.Path.EndsInDirectorySeparator(string)"/>
        bool EndsInDirectorySeparator(string path);

        /// <inheritdoc cref="System.IO.Path.TrimEndingDirectorySeparator(ReadOnlySpan{char})"/> 
        ReadOnlySpan<char> TrimEndingDirectorySeparator(ReadOnlySpan<char> path);
        /// <inheritdoc cref="System.IO.Path.TrimEndingDirectorySeparator(string)" />
        string TrimEndingDirectorySeparator(string path);
#endif

#if FEATURE_PATH_JOIN_WITH_FOUR_PATHS
        /// <inheritdoc cref="System.IO.Path.Join(ReadOnlySpan{char}, ReadOnlySpan{char}, ReadOnlySpan{char}, ReadOnlySpan{char})" />
        string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3, ReadOnlySpan<char> path4);

        /// <inheritdoc cref="System.IO.Path.Join(string?, string?, string?, string?)" />
        string Join(string path1, string path2, string path3, string path4);
#endif
    }
}