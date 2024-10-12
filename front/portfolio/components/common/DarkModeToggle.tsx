"use client";
import React from "react";
import { useTheme } from "next-themes";
import { RiMoonLine, RiSunLine } from "react-icons/ri";
import Switch from "./Switch";

const DarkModeToggle = () => {
    const { theme, setTheme, resolvedTheme } = useTheme();

    function handleChange(checked: boolean) {
        console.log(checked);
        setTheme(checked ? "dark" : "light");
    }

    return (
        <Switch isChecked={resolvedTheme == "dark"} onToggle={handleChange} />
    );
};

export default DarkModeToggle;