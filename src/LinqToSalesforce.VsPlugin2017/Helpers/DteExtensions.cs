using System;
using System.Collections.Generic;
using EnvDTE;
using VSLangProj;

namespace LinqToSalesforce.VsPlugin2017.Helpers
{
    public static class DteExtensions
    {

        public static Project GetCurrentProject(this DTE dte)
        {
            var activeSolutionProjects = (Array)dte.ActiveSolutionProjects;
            if (activeSolutionProjects.Length <= 0)
                return null;

            return (Project)activeSolutionProjects.GetValue(0);
        }

        public static VSProject GetCurrentVsProject(this DTE dte) => GetCurrentProject(dte)?.Object as VSProject;

        public static IEnumerable<Reference> GetReferences(this Project project)
        {
            var vsProject = project?.Object as VSProject;
            if (vsProject == null)
                yield break;

            foreach (var r in vsProject.References)
                yield return (Reference)r;
        }

        public static IEnumerable<ProjectItem> GetProjectFiles(this Project project)
        {
            if (project == null)
                yield break;

            foreach (var p in project.Collection)
            {
                var proj = (Project)p;
                foreach (var sp in proj.ProjectItems)
                {
                    yield return (ProjectItem)sp;
                }
            }
        }
    }
}
