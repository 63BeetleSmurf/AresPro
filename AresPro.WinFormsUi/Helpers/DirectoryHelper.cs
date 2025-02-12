﻿namespace AresPro.WinFormsUi.Helpers;

public static class DirectoryHelper
{
    public static readonly string InstallPath = Application.StartupPath;
    public static readonly string FederationsPath = Path.Combine(InstallPath, "");
    public static readonly string CommentaryPath = Path.Combine(InstallPath, "commentary");
    public static readonly string GimmicksPath = Path.Combine(InstallPath, "gimmicks");
    public static readonly string MovesPath = Path.Combine(InstallPath, "moves");
    public static readonly string ImportFilePath = Path.Combine(InstallPath, "");
    public static readonly string ResultsPath = Path.Combine(InstallPath, "results");
    public static readonly string AssetsPath = Path.Combine(InstallPath, "Assets");
    public static readonly string HTMLTemplatesPath = Path.Combine(AssetsPath, "HTMLTemplates");
}
