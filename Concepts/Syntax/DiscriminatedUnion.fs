namespace Psych.Concepts.Syntax

module DiscriminatedUnion =
    (* Without discriminated union *)
    type StringGitHubProject =
        { ProjectName: string
          Stars: int
          State: string }

    let fakeProject =
        { ProjectName = "Awesome Project"
          Stars = 0
          State = "Inactive" }

    (* With discriminated union *)
    type ProjectState =
        | Archived
        | Active of {| Maintainer: string |} // Anonymous record

    type DiscriminatedGitHubProject =
        { ProjectName: string
          Stars: int
          State: ProjectState }

    let proj: DiscriminatedGitHubProject =
        { ProjectName = "XX"
          Stars = 1
          State = Archived }

    let proj2: DiscriminatedGitHubProject =
        { ProjectName = "YY"
          Stars = 2
          State = Active {| Maintainer = "Team" |}}

    let isMaintainedByTeam (proj: DiscriminatedGitHubProject) =
        match proj.State with
        | Archived -> printfn "not sure"
        | Active(M) when M.Maintainer = "Team" -> printfn "yes"
        | _ -> printfn "nope"
