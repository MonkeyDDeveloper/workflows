"use client";
import React from "react";
import { useTheme } from "next-themes";
import { RiMoonLine, RiSunLine } from "react-icons/ri";
import Switch from "./Switch";

const DarkModeToggle = () => {
    const { theme, setTheme } = useTheme();

    function handleChange(checked: boolean) {
        setTheme(checked ? "dark" : "light");
    }

    return (
        <Switch isChecked={theme == "dark"} onToggle={handleChange} />
    );
};

export default DarkModeToggle;