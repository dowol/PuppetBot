using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PuppetBot;

public static class FileSystem
{
    static FileSystem()
    {
        
    }


    public static DirectoryInfo AppData
    {
        get => new(Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Puppet.AppName));
    }

    public static DirectoryInfo LocalAppData
    {
        get => new(Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Puppet.AppName));
    }

    public static DirectoryInfo Configurations
    {
        get => AppData.InitDir("config");
    }

    public static DirectoryInfo Databases
    {
        get => AppData.InitDir("db");
    }

    

    public static DirectoryInfo Profiles
    {
        get => AppData.InitDir("profile");
    }

    public static DirectoryInfo Logs
    {
        get => LocalAppData.InitDir("log");
    }

    public static DirectoryInfo DebugData
    {
        get => LocalAppData.InitDir("debug");
    }

    private static DirectoryInfo InitDir(this DirectoryInfo root, params string[] paths)
    {
        DirectoryInfo result = new(Path.Join(root.FullName, Path.Join(paths)));
        if (!result.Exists) result.Create();
        return result;
    }

    private static FileInfo InitFile(this DirectoryInfo root, params string[] paths)
    {
        return new(Path.Join(root.FullName, Path.Join(paths)));
    }




}
