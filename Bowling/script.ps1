$msbuild ='C:\Program Files (x86)\Microsoft Visual Studio\2019\Preview\MSBuild\Current\Bin\MSBuild.exe'
$sol = 'C:\development\projects\bowling\Bowling\Bowling.sln '
$opt1 = '/t:rebuild'
$opt2 = '/verbosity:quiet'

& $msbuild $sol $opt1 $opt2

if ($LASTEXITCODE -eq 0) {
    $nunit_console = 'C:\development\projects\bowling\Bowling\packages\NUnit.ConsoleRunner.3.9.0\tools\nunit3-console.exe'
    $tests = 'C:\development\projects\bowling\Bowling\BowlingTests\bin\Debug\BowlingTests.dll'
    $opt1 = '--stoponerror'
    $opt2 = '--noresult'

    & $nunit_console $tests $opt1 $opt2
}


Write-Host "EXIT CODE NUNIT = $LASTEXITCODE"