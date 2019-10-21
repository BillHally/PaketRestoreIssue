#load ".fake/build.fsx/intellisense.fsx"
open Fake.Core
open Fake.DotNet
open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.IO.Globbing.Operators
open Fake.Core.TargetOperators

Target.initEnvironment ()

Target.create
    "PaketRestore"
    (
        fun _ ->
            Paket.restore
                (
                    fun p ->
                        {
                            p with
                                ForceDownloadOfPackages = true
                        }
                )
    )

Target.runOrDefault "PaketRestore"
